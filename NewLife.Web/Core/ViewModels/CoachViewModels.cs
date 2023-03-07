using Newlife.Web.Core.Models;

namespace NewLife.Web.Core.ViewModels
{
   public class CoachViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

  
        public bool IsActive { get; set; }
    }

   
    public class CoachesIndexViewModel
    {
        public List<CoachViewModel> Coaches { get; set; }

    }
    


    public class CreateCoachViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<IFormFile>? Attachments { get; set; }

        public IFormFile MainImage { get; set; }

        // contact info
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

      

    }

}
