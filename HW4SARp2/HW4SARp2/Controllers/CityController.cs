using HW4SARp2.Entities;
using HW4SARp2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HW4SARp2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly ICityDetails _cityDetails;

        public CityController(ICityDetails cityDetails)
        {
            _cityDetails = cityDetails;
        }

        [HttpGet("{CID}")]
        public async Task<ActionResult<List<City>>> GetCityDetails(int CID)
        {
            var cityDeets = await _cityDetails.GetCityDetails(CID);
            if (cityDeets == null)
            {
                return NotFound();
            }
            return Ok(cityDeets);
        }
    }
}