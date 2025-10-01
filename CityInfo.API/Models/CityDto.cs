namespace CityInfo.API.Models;

public class CityDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int AttractionsCount
    {
        get
        {
            return Attractions.Count;
        }
    }

    public ICollection<AttractionDto> Attractions { get; set; } = new List<AttractionDto>();
}
