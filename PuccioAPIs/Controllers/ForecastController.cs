using Microsoft.AspNetCore.Mvc;
using PuccioAPIs.Repositories;
using PuccioAPIs.Entities;

namespace PuccioAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForecastController : ControllerBase
    {
        private readonly IForecastService _ForecastService;
        public ForecastController(IForecastService ForecastService)
        {
            this._ForecastService = ForecastService;
        }
        [HttpGet("{CID}")]
        public async Task<ActionResult<List<Forecast>>> GetForecast(int CID)
        {
            var cast = await _ForecastService.GetForecast(CID);
            if (cast == null)
            {
                return NotFound();
            }
            return cast;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddCast(Forecast forecast)
        {
            var cast = await _ForecastService.AddCast(forecast);
            if (cast == 0)
            {
                return NotFound();
            }
            return cast;
        }
    }
}
