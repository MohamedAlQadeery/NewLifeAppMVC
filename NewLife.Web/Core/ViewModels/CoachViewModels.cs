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

        public string MainImage { get; set; }

        public DateTime CreatedAt { get; set; }
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



    public class EditCoachViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessageResourceName = "required_error", ErrorMessageResourceType = typeof(SharedResource))]
        [Display(Name="الاسم")]
        public string Name { get; set; }
        [Required(ErrorMessageResourceName = "required_error", ErrorMessageResourceType = typeof(SharedResource))]
        [Display(Name = "الوصف")]
        public string Description { get; set; }

        [Display(Name = "صورة الرئيسية")]
        [AdaptIgnore]
        public IFormFile? MainImage { get; set; }

        [Display(Name = "البريد الإلكتروني")]
        [EmailAddress(ErrorMessageResourceName = "email_error", ErrorMessageResourceType = typeof(SharedResource))]
        [Required(ErrorMessageResourceName = "required_error", ErrorMessageResourceType = typeof(SharedResource))]
        public string Email { get; set; }

        [Display(Name = "رقم الهاتف")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "فيسبوك")]
        public string? Facebook { get; set; }

        [Display(Name = "إنستغرام")]
        public string? Instagram { get; set; }

        [Display(Name = "لينكدإن")]
        public string? Linkedin { get; set; }

        [Display(Name = "تويتر")]
        public string? Twitter { get; set; }

        [Display(Name = "واتساب")]
        public string? Whatsapp { get; set; }

        public string MainImagePreview { get; set; }

    }


    public class CoachAttachmentViewModel
    {
        public int Id { get; set; }
        public int CoachId { get; set; }

        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
        public string? PublicId { get; set; }

        public bool IsImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }

    public class CreateCoachAttachmentViewModel
    {
        public int CoachId { get; set; }
        public string CoachName { get; set; }
        public bool IsImage { get; set; }

        public List<IFormFile>? Images { get; set; }

        public List<string>? VideosLinks { get; set; }

    }
}
