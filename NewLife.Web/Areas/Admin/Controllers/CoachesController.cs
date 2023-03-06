using Microsoft.AspNetCore.Mvc;

namespace NewLife.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoachesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
