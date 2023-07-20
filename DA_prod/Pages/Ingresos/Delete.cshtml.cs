using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DA_prod.Data;
using DA_prod.Models;

namespace DA_prod.Pages.Ingresos
{
    public class DeleteModel : PageModel
    {
        private readonly DA_prod.Data.PacientesContext _context;

        public DeleteModel(DA_prod.Data.PacientesContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Pacientes Pacientes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.paciente == null)
            {
                return NotFound();
            }

            var pacientes = await _context.paciente.FirstOrDefaultAsync(m => m.ID == id);

            if (pacientes == null)
            {
                return NotFound();
            }
            else 
            {
                Pacientes = pacientes;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.paciente == null)
            {
                return NotFound();
            }
            var pacientes = await _context.paciente.FindAsync(id);

            if (pacientes != null)
            {
                Pacientes = pacientes;
                _context.paciente.Remove(Pacientes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
