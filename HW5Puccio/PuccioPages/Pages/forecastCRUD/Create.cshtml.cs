using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PleaseWork.Data;
using PuccioAPIs.Entities;

namespace PleaseWork.Pages.forecastCRUD
{
 
    public class CreateModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly PleaseWork.Data.ApplicationDbContext _context;

        public CreateModel(PleaseWork.Data.ApplicationDbContext context, IHttpClientFactory clientFactory)
        {
            _context = context;
            _clientFactory = clientFactory;
    }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Forecast Forecast { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:7231/api/Forecast");
            request.Content = new StringContent(JsonSerializer.Serialize(Forecast), Encoding.UTF8, "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                return Page();
            }


        }
    }
}
