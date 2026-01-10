
namespace LighthouseSocial.Domain.Countries;

public class CountryRegister(IEnumerable<Country> countries) : ICountryRegister
{
    private readonly Dictionary<int, Country> _countries = countries.ToDictionary(c => c.Id);
    public IReadOnlyList<Country> getAll()
    {
        return [.. _countries.Values];
    }

    public Country getById(int id)
    {
        return _countries.TryGetValue(id, out var country)
            ? country 
            : throw new KeyNotFoundException($"Country id not found:{id}");
    }
}
