using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISTeamProjectAPI.Repositories;
using MISTeamProjectAPI.Entities;
using Microsoft.Extensions.Hosting;

namespace MISTeamProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisasterController : ControllerBase
    {
        private readonly IntDisasterService _DisasterService;
        public DisasterController(IntDisasterService DisasterService)
        {
            _DisasterService = DisasterService;
        }
        [HttpGet("{CID}")]
        public async Task<ActionResult<List<Disaster>>> GetCityDisasters(int CID)
        {
            var disasterDetails = await _DisasterService.GetCityDisasters(CID);
            if (disasterDetails == null)
            {
                return NotFound();
            }
            return disasterDetails;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddDisaster(Disaster disaster)
        {
            var DisasterDetails = await _DisasterService.AddDisaster(disaster);
            if (DisasterDetails == 0)
            {
                // return NotFound();
            }
            return DisasterDetails;
        }
    }
}

