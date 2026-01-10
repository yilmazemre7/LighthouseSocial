using LighthouseSocial.Domain.Common;

namespace LighthouseSocial.Domain.Entities;

public class Comment
    :EntityBase
{
    public Guid UserId { get; set; }
    public Guid PhotoId { get; set; }
    public string Text { get; set; }
    public Rating Rating { get; set; }
    public DateTime CreatedAt { get; set; }
    protected Comment() { }

    public Comment(Guid userId, Guid photoId, string text, Rating rating)
    {
        UserId = userId;
        PhotoId = photoId;
        Text = text;
        Rating = rating;
        CreatedAt = DateTime.UtcNow;
    }
}
