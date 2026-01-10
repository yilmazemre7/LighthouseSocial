using LighthouseSocial.Application.Common;
using LighthouseSocial.Application.Dtos;
using LighthouseSocial.Domain.Countries;
using LighthouseSocial.Domain.Interfaces;
using LighthouseSocial.Domain.ValueObjects;

namespace LighthouseSocial.Application.Features.Lighthouse;

public class CreateLighthouseHandler
{
    private readonly ILighthouseRepository _repository;
    private readonly ICountryRegister _countryRegister;

    public CreateLighthouseHandler(ILighthouseRepository repository, ICountryRegister countryRegister)
    {
        _repository = repository;
        _countryRegister = countryRegister;
    }

    public async Task<Result<Guid>> HandleAsync(LighthouseDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name))
        {
            return Result<Guid>.Fail("Lighthouse name is required");
        }
        Country? country;
        try
        {
            country = _countryRegister.GetById(dto.CountryId);
        }
        catch (Exception ex)
        {

            return Result<Guid>.Fail($"Invalid country id: {dto.CountryId}. Error: {ex.Message}");
        }
        var location = new Coordinates(dto.Latitude, dto.Longitude);
        var lighthouse = new Domain.Entities.Lighthouse(dto.Name, country, location);
        await _repository.AddAsync(lighthouse);
        return Result<Guid>.Ok(lighthouse.Id);
    }
}
