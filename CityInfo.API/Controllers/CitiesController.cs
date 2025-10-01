using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Models;

[Route("api/cities")]
[ApiController]
public class CitiesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<CityDto>> GetCities()
    {
        return Ok(CitiesDataStore.Instance.Cities);
    }

    [HttpGet("{id}")]
    public ActionResult<CityDto> GetCity(int id)
    {
        var city = CitiesDataStore.Instance.Cities.FirstOrDefault(c => c.Id == id);

        if (city == null)
            return NotFound();

        return Ok(city);
    }
    
}
