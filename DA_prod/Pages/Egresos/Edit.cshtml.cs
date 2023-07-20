﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DA_prod.Data;
using DA_prod.Models;

namespace DA_prod.Pages.Egresos
{
    public class EditModel : PageModel
    {
        private readonly DA_prod.Data.PacientesContext _context;

        public EditModel(DA_prod.Data.PacientesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Egresado Egresado { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Egresado == null)
            {
                return NotFound();
            }

            var egresado =  await _context.Egresado.FirstOrDefaultAsync(m => m.ID == id);
            if (egresado == null)
            {
                return NotFound();
            }
            Egresado = egresado;
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

            _context.Attach(Egresado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EgresadoExists(Egresado.ID))
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

        private bool EgresadoExists(int id)
        {
          return (_context.Egresado?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
