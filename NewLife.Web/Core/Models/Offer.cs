namespace Newlife.Web.Core.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool isActive { get; set; } = true;
        public List<OfferAttachment> Attachments { get; set; }
    }

}
