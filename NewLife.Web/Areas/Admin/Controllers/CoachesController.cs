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
    }
}
