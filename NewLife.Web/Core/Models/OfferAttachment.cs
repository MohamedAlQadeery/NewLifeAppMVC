using System.ComponentModel.DataAnnotations.Schema;

namespace Newlife.Web.Core.Models
{
    public class OfferAttachment : Attachment
    {
        [ForeignKey("Offer")]
        public int OfferId { get; set; }

        public Offer Offer { get; set; }
    }
}
