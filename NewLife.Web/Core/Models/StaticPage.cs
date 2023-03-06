using NewLife.Web.Core.Models;

namespace Newlife.Web.Core.Models
{
    public class StaticPage : BaseModel
    {
        public string Name { get; set; }
        public string Body { get; set; }

        public bool HasForm { get; set; } = false;
    }
}
