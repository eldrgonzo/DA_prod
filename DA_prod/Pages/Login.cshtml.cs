using DA_prod.Models;
using Microsoft.EntityFrameworkCore;
using DA_prod.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DA_prod.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]

        public Servidores Modelo { get; set; }

        private readonly PacientesContext db;

        public LoginModel(PacientesContext db)
        {
            this.db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                var existeFolioInterno = await db.servidor.AnyAsync(x => x.UserName == Modelo.UserName);
                if (existeFolioInterno)
                {
                    TempData["error"] = "El nombre de usuario " + Modelo.UserName + " ya existe";
                    return Page();
                }
                this.db.Add(Modelo);
                await db.SaveChangesAsync();
                return RedirectToPage("/Create");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return Page();
            }
        }
    }
}
