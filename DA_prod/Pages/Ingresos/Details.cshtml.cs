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
    public class DetailsModel : PageModel
    {
        private readonly DA_prod.Data.PacientesContext _context;

        public DetailsModel(DA_prod.Data.PacientesContext context)
        {
            _context = context;
        }

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
    }
}
