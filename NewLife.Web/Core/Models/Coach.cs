using NewLife.Web.Core.Models;

namespace Newlife.Web.Core.Models
{
    public class Coach : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<CoachAttachment> Attachments { get; set; }

        // contact info
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Linkedin { get; set; }
        public string? Twitter { get; set; }
        public string? Whatsapp { get; set; }
        //end contact info

    }
}
