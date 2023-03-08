﻿using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Newlife.Web.Core.Interfaces;
using Newlife.Web.Core.Models;
using NewLife.Web.Core.ViewModels;
using NewLife.Web.Services.Interfaces;

namespace NewLife.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoachesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;

        public CoachesController(IUnitOfWork unitOfWork,IMapper mapper,IImageService imageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _imageService = imageService;
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
        public async Task<IActionResult> Create(CreateCoachViewModel createCoachViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createCoachViewModel);
            }

            var coachToCreate = _mapper.Map<Coach>(createCoachViewModel);
            coachToCreate.MainImage = await _imageService.UploadImageAsync(createCoachViewModel.MainImage);

           var createdCoach= await _unitOfWork.Coaches.AddAsync(coachToCreate);
           if (await _unitOfWork.SaveChanges() <= 0)
            {
                TempData["error"] = "حدث خطأ في الاضافة";
                return View(createCoachViewModel);

            }

            TempData["success"] = "تمت الاضافة بنجاح";

            return RedirectToAction(nameof(Index));
        }
    }
}
