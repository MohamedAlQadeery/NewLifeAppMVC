using System.ComponentModel.DataAnnotations.Schema;

namespace Newlife.Web.Core.Models
{
    public class CoachAttachment : Attachment
    {
        [ForeignKey("Coach")]
        public int CoachId { get; set; }
        public Coach Coach { get; set; }
    }
}
