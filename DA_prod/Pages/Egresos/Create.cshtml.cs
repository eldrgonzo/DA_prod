using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DA_prod.Data;
using DA_prod.Models;

namespace DA_prod.Pages.Egresos
{
    public class CreateModel : PageModel
    {
        private readonly DA_prod.Data.PacientesContext _context;

        public CreateModel(DA_prod.Data.PacientesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Egresado Egresado { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Egresado == null || Egresado == null)
            {
                return Page();
            }

            _context.Egresado.Add(Egresado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
