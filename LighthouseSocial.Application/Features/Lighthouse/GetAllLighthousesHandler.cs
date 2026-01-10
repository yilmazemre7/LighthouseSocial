using LighthouseSocial.Application.Common;
using LighthouseSocial.Application.Dtos;
using LighthouseSocial.Domain.Interfaces;

namespace LighthouseSocial.Application.Features.Lighthouse;

public class GetAllLighthousesHandler
{
    private readonly ILighthouseRepository _repository;

    public GetAllLighthousesHandler(ILighthouseRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<IEnumerable<LighthouseDto>>> HandleAsync(LighthouseDto dto)
    {

        var lighthouses = await _repository.GetAllAsync();
        if (!lighthouses.Any())
        {
            return Result<IEnumerable<LighthouseDto>>.Fail("No lighthouses found.");
        }
        var dtos = lighthouses.Select(x => new LighthouseDto(
            x.Id,
            x.Name,
            x.CountryId,
            x.Location.Latitude,
            x.Location.Longitude));

        return Result<IEnumerable<LighthouseDto>>.Ok(dtos);
    }
}
