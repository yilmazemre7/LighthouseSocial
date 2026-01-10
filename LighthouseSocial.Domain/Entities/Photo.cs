using LighthouseSocial.Domain.Common;
using LighthouseSocial.Domain.ValueObjects;

namespace LighthouseSocial.Domain.Entities
{
    public class Photo
        : EntityBase
    {
        public Guid UserId { get; set; }
        public Guid LighthouseId { get; set; }
        public string Filename { get; set; }
        public DateTime UploadDate { get; set; }
        public PhotoMetadata Metadata { get; set; }
        public List<Comment> Comments { get; } = [];

        protected Photo() { }

        public Photo(Guid userId, Guid lighthouseId, string filename, PhotoMetadata metadata)
        {
            UserId = userId;
            LighthouseId = lighthouseId;
            Filename = filename;
            UploadDate = DateTime.UtcNow;
            Metadata = metadata;
        }
    }
}
