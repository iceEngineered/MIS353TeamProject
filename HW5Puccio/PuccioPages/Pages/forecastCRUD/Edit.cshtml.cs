using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PleaseWork.Data;
using PuccioAPIs.Entities;

namespace PleaseWork.Pages.forecastCRUD
{
    public class EditModel : PageModel
    {
        private readonly PleaseWork.Data.ApplicationDbContext _context;

        public EditModel(PleaseWork.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Forecast Forecast { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forecast = await _context.Forecast.FirstOrDefaultAsync(m => m.CID == id);
            if (forecast == null)
            {
                return NotFound();
            }
            Forecast = forecast;
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

            _context.Attach(Forecast).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ForecastExists(Forecast.CID))
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

        private bool ForecastExists(int id)
        {
            return _context.Forecast.Any(e => e.CID == id);
        }
    }
}