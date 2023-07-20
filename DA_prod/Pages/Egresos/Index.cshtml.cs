using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DA_prod.Data;
using DA_prod.Models;

namespace DA_prod.Pages.Egresos
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PacientesContext _db;

        public IEnumerable<Egresado> Modelo { get; set; }


        public IndexModel(ILogger<IndexModel> logger, PacientesContext db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task OnGet()
        {
            try
            {
                Modelo = await _db.Egresado.ToListAsync();
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
                var EgresadoDB = await _db.Egresado.FindAsync(ID);
                if (EgresadoDB == null)
                {
                    TempData["error"] = "Usuario desconocido";
                }
                else
                {
                    _db.Egresado.Remove(EgresadoDB);
                    await _db.SaveChangesAsync();
                    TempData["mensaje"] = "Usuario " + EgresadoDB.Nombre + " eliminado de lista de egresados.";
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
