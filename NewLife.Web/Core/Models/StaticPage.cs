namespace Newlife.Web.Core.Models
{
    public class StaticPage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }

        public bool HasForm { get; set; } = false;
        public bool IsActive { get; set; }
    }
}
