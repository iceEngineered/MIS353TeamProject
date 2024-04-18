using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MISTeamProject.Data;
using MISTeamProjectAPI.Entities;

namespace MISTeamProject.Pages
{
    public class DisastersByCityModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DisastersByCityModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Disaster> Disaster { get; set; } = new List<Disaster>();

        public async Task OnGetAsync(int? CID)
        {
            if (CID.HasValue)
            {
                Disaster = await _context.Disaster
                    .Where(d => d.CID == CID)
                    .ToListAsync();
            }
            else
            {
                Disaster = await _context.Disaster.ToListAsync();
            }
        }
    }
}
