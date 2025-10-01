using CityInfo.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers;

[Route("api/cities/{cityId}/attractions")]
[ApiController]
public class AttractionsController : ControllerBase
{
    [HttpGet()]
    public ActionResult<IEnumerable<AttractionDto>> GetAttractions(int cityId)
    {
        var city = CitiesDataStore.Instance.Cities.FirstOrDefault(c => c.Id == cityId);

        if (city == null)
            return NotFound();

        var attractions = city.Attractions.ToList();

        return Ok(attractions);
    }

    [HttpGet("{attractionId}")]
    public ActionResult<AttractionDto> GetAttraction(int cityId, int attractionId)
    {
        var city = CitiesDataStore.Instance.Cities.FirstOrDefault(c => c.Id == cityId);

        if (city == null)
            return NotFound();

        var attraction = city.Attractions.FirstOrDefault(c => c.Id == attractionId);

        if (attraction == null)
            return NotFound();

        return Ok(attraction);
    }
}
