using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DA_prod.Data;
using DA_prod.Models;

namespace DA_prod.Pages.Ingresos
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
        public Pacientes Pacientes { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.paciente == null || Pacientes == null)
            {
                return Page();
            }

            _context.paciente.Add(Pacientes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
