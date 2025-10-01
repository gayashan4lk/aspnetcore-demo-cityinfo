using CityInfo.API.Models;

namespace CityInfo.API;

public class CitiesDataStore
{
    public List<CityDto> Cities { get; set; }

    public static CitiesDataStore Instance { get; set; } = new CitiesDataStore();

    public CitiesDataStore()
    {
        Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id = 1,
                Name = "New York City",
                Description = "The city that never sleeps"
            },
            new CityDto()
            {
                Id = 2,
                Name = "Los Angeles",
                Description = "The entertainment capital of the world"
            },
            new CityDto()
            {
                Id = 3,
                Name = "Chicago",
                Description = "The Windy City"
            }

        };


    }
}
