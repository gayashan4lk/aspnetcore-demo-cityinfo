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
                Description = "The city that never sleeps",
                Attractions = new List<AttractionDto>()
                {
                    new AttractionDto()
                    {
                        Id = 1,
                        Name = "Statue of Liberty & Ellis Island",
                        Description = "An iconic symbol of freedom and U.S. immigration history, accessible by ferry from Battery Park. Includes the Statue of Liberty and the Ellis Island Immigration Museum."
                    },
                    new AttractionDto()
                    {
                        Id = 2,
                        Name = "Central Park",
                        Description = "A vast urban park in the heart of Manhattan featuring lakes, trails, the Central Park Zoo, and landmarks like Bethesda Terrace."
                    },
                    new AttractionDto()
                    {
                        Id = 3,
                        Name = "Times Square",
                        Description = "A bustling entertainment district known for its neon lights, Broadway theaters, shopping, and the famous New Year's Eve ball drop."
                    },
                    new AttractionDto()
                    {
                        Id = 4,
                        Name = "Empire State Building / Top of the Rock",
                        Description = "Skyscraper observatories offering breathtaking panoramic views of New York City. The Empire State is iconic, while Top of the Rock provides a view of the Empire State itself."
                    },
                    new AttractionDto()
                    {
                        Id = 5,
                        Name = "The Metropolitan Museum of Art (The Met)",
                        Description = "One of the world's largest and finest art museums, featuring a vast collection spanning ancient artifacts to modern masterpieces."
                    }
                }
            },
            new CityDto()
            {
                Id = 2,
                Name = "Los Angeles",
                Description = "The entertainment capital of the world",
                Attractions = new List<AttractionDto>()
                {
                    new AttractionDto()
                    {
                        Id = 6,
                        Name = "Hollywood Walk of Fame",
                        Description = "A famous sidewalk along Hollywood Boulevard featuring over 2,700 brass stars honoring celebrities from film, television, music, and theater."
                    },
                    new AttractionDto()
                    {
                        Id = 7,
                        Name = "Griffith Observatory & Griffith Park",
                        Description = "An iconic observatory offering exhibits, a planetarium, and sweeping views of Los Angeles, including the Hollywood Sign. Located within Griffith Park, a vast urban park with hiking trails."
                    },
                    new AttractionDto()
                    {
                        Id = 8,
                        Name = "Santa Monica Pier",
                        Description = "A historic pier featuring an amusement park, aquarium, shops, restaurants, and stunning ocean views. A classic California experience."
                    }
                }

            },
            new CityDto()
            {
                Id = 3,
                Name = "Chicago",
                Description = "The Windy City",
                Attractions = new List<AttractionDto>()
                {
                    new AttractionDto()
                    {
                        Id = 9,
                        Name = "Millennium Park & Cloud Gate",
                        Description = "A central gathering spot in downtown Chicago, home to the famous 'Cloud Gate' sculpture (also known as 'The Bean'), outdoor art, gardens, and public events."
                    },
                    new AttractionDto()
                    {
                        Id = 10,
                        Name = "Art Institute of Chicago",
                        Description = "One of the oldest and largest art museums in the United States, featuring renowned works such as Grant Wood's 'American Gothic' and Georges Seurat's 'A Sunday on La Grande Jatte.'"
                    }
                }
            }

        };


    }
}
