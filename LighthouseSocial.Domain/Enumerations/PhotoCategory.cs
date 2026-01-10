using LighthouseSocial.Domain.Common;

namespace LighthouseSocial.Domain.Enumerations;

public sealed class PhotoCategory
    : EnumerationBase
{

    public static readonly PhotoCategory Sunset = new PhotoCategory(1, "Sunset");
    public static readonly PhotoCategory Historical = new PhotoCategory(2, "Historical");
    public static readonly PhotoCategory Storm = new PhotoCategory(3, "Storm");
    public static readonly PhotoCategory Sundown = new PhotoCategory(3, "Sundown");
    private PhotoCategory(int id, string name) : base(id, name)
    {
    }

    public static IEnumerable<PhotoCategory> List() => [Sunset, Historical, Storm, Sundown];

    public static PhotoCategory FromId(int id)
    {
        return List().FirstOrDefault(x => x.Id == id) ?? throw new ArgumentOutOfRangeException();
    }

}
