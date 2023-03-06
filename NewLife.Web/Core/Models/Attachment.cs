using NewLife.Web.Core.Models;

namespace Newlife.Web.Core.Models
{
    public abstract class Attachment : BaseModel
    {
    
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
        public string PublicId { get; set; }

        public bool IsImage { get; set; }
       
    }
}
