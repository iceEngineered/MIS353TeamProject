using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PleaseWork.Data;
using PuccioAPIs.Entities;

namespace PleaseWork.Pages.HotelCRUD
{
    public class DeleteModel : PageModel
    {
        private readonly PleaseWork.Data.ApplicationDbContext _context;

        public DeleteModel(PleaseWork.Data.ApplicationDbContext context)
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
            else
            {
                Forecast = forecast;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forecast = await _context.Forecast.FindAsync(id);
            if (forecast != null)
            {
                Forecast = forecast;
                _context.Forecast.Remove(Forecast);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
