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
    public class IndexModel : PageModel
    {
        private readonly PleaseWork.Data.ApplicationDbContext _context;

        public IndexModel(PleaseWork.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Forecast> Forecast { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Forecast = await _context.Forecast.ToListAsync();
        }
    }
}
