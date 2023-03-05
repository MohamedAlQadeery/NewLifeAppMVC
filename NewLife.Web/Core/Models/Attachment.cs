namespace Newlife.Web.Core.Models
{
    public abstract class Attachment
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
        public string PublicId { get; set; }

        public bool IsImage { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
