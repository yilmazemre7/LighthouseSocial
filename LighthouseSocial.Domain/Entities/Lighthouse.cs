using LighthouseSocial.Domain.Common;
using LighthouseSocial.Domain.Countries;
using LighthouseSocial.Domain.ValueObjects;

namespace LighthouseSocial.Domain.Entities;

public class Lighthouse : EntityBase
{
    public string Name { get; private set; } = string.Empty;
    public int CountryId { get; private set; }
    public Country Country { get; private set; } = null!;
    public Coordinates Location { get; private set; }
    public List<Photo> Photos { get; } = [];

    protected Lighthouse() { }

    public Lighthouse(string name, Country country, Coordinates location, Guid? id = null)
    {
        Id = id ?? Guid.NewGuid(); 
        Name = name;
        Country = country;
        CountryId = country.Id;
        Location = location;
    }
}