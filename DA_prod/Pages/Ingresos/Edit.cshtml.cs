using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DA_prod.Data;
using DA_prod.Models;

namespace DA_prod.Pages.Ingresos
{
    public class EditModel : PageModel
    {
        private readonly DA_prod.Data.PacientesContext _context;

        public EditModel(DA_prod.Data.PacientesContext context)
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

            var pacientes =  await _context.paciente.FirstOrDefaultAsync(m => m.ID == id);
            if (pacientes == null)
            {
                return NotFound();
            }
            Pacientes = pacientes;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pacientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PacientesExists(Pacientes.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PacientesExists(int id)
        {
          return (_context.paciente?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
