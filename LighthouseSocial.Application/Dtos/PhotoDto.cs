namespace LighthouseSocial.Application.Dtos;

public record PhotoDto(Guid id, string fileName, DateTime uploadedAt, string cameraModel, Guid userId, Guid lighthouseId);