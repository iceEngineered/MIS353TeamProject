using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MISTeamProject.Data;
using MISTeamProjectAPI.Entities;

namespace MISTeamProject.Pages
{
    public class AddDisasterModel : PageModel
    {
        private readonly MISTeamProject.Data.ApplicationDbContext _context;

        public AddDisasterModel(MISTeamProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Disaster Disaster { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Disaster.Add(Disaster);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
