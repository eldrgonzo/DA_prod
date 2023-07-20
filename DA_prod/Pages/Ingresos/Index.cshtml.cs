
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DA_prod.Data;
using DA_prod.Models;

namespace DA_prod.Pages.Ingresos
{

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PacientesContext _db;

        public IEnumerable<Pacientes> Modelo { get; set; }
        

        public IndexModel(ILogger<IndexModel> logger, PacientesContext db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task OnGet()
        {
            try
            {
                Modelo = await _db.paciente.ToListAsync();
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                Page();
            }
        }

        public async Task<IActionResult> OnPostDelete(int ID)
        {
            try
            {
                var PacienteDB = await _db.paciente.FindAsync(ID);
                if (PacienteDB == null)
                {
                    TempData["error"] = "Usuario desconocido";
                }
                else
                {
                    _db.paciente.Remove(PacienteDB);
                    await _db.SaveChangesAsync();
                    TempData["mensaje"] = "Usuario " + PacienteDB.Nombre + " eliminado de lista de ingresados.";
                    return RedirectToPage("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return Page();

        }
    }
}
