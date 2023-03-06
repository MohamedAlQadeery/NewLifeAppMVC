using NewLife.Web.Core.Models;

namespace Newlife.Web.Core.Models
{
    public class Offer : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<OfferAttachment> Attachments { get; set; }
    }

}
