using LighthouseSocial.Application.Dtos;

namespace LighthouseSocial.Application.Contracts;
public interface ILighthouseService
{
    Task<IEnumerable<LighthouseDto>> GetAllAsync();
    Task<LighthouseDto?> GetIdByAsync(Guid id);
    Task<Guid> CreateAsync(LighthouseDto dto);
    Task<Guid> UpdateAsync(Guid id, LighthouseDto dto);
    Task DeleteAsync(Guid id);
}
