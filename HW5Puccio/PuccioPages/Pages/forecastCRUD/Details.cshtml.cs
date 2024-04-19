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
    public class DetailsModel : PageModel
    {
        private readonly PleaseWork.Data.ApplicationDbContext _context;

        public DetailsModel(PleaseWork.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}