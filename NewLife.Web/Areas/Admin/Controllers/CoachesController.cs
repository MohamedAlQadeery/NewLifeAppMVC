using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Newlife.Web.Core.Interfaces;
using NewLife.Web.Core.ViewModels;

namespace NewLife.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoachesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CoachesController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var coaches = await _unitOfWork.Coaches.GetAllAsync();
            var coachesVM = new CoachesIndexViewModel { Coaches = _mapper.Map<List<CoachViewModel>>(coaches) };           

            return View(coachesVM);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateCoachViewModel());
        }

        [HttpPost]
        public IActionResult Create(CreateCoachViewModel createCoachViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createCoachViewModel);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
