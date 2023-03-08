using Mapster;
using Newlife.Web.Core.Models;
using NewLife.Web.Resources;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessageResourceName = "required_error", ErrorMessageResourceType = typeof(SharedResource))]
        public string Name { get; set; }
        [Required(ErrorMessageResourceName = "required_error", ErrorMessageResourceType = typeof(SharedResource))]

        public string Description { get; set; }

        public List<IFormFile>? Attachments { get; set; }

        [Required(ErrorMessageResourceName = "required_error", ErrorMessageResourceType = typeof(SharedResource))]
        [Display(Name="صورة الرئيسية")]
        [AdaptIgnore]
        public IFormFile MainImage { get; set; }

        // contact info
        public string? PhoneNumber { get; set; }
        [EmailAddress(ErrorMessageResourceName = "email_error", ErrorMessageResourceType = typeof(SharedResource))]
        [Required(ErrorMessageResourceName = "required_error", ErrorMessageResourceType = typeof(SharedResource))]

        public string Email { get; set; }

      

    }

}
