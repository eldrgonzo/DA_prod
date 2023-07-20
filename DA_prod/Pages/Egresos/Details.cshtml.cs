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
    public class DetailsModel : PageModel
    {
        private readonly DA_prod.Data.PacientesContext _context;

        public DetailsModel(DA_prod.Data.PacientesContext context)
        {
            _context = context;
        }

      public Egresado Egresado { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Egresado == null)
            {
                return NotFound();
            }

            var egresado = await _context.Egresado.FirstOrDefaultAsync(m => m.ID == id);
            if (egresado == null)
            {
                return NotFound();
            }
            else 
            {
                Egresado = egresado;
            }
            return Page();
        }
    }
}
