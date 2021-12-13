using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.DataAccess;
using TimetableApp.DataAccess.Entities;
using TimetableApp.Business.DTO;
using TimetableApp.Business.Services;
using TimetableApp.Business.IServices;
using AutoMapper;
using TimetableApp.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace TimetableApp.Web.Controllers
{
    public class ClassroomController : Controller
    {
        IClassroomsService _classroomsService;
        IBuildingService _buildingService;
        IClassroomTypeService _classroomTypeService;
        private IMapper _mapper { get; set; }
        public ClassroomController(IClassroomsService classroomsService, IMapper mapper, IBuildingService buildingService, IClassroomTypeService classroomTypeService)
        {
            _classroomsService = classroomsService;
            _mapper = mapper;
            _buildingService = buildingService;
            _classroomTypeService = classroomTypeService;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber, string searchString)
        {
            var model = _classroomsService.GetAllClassrooms().Select(x => new ClassroomViewModel
            {
                ClassroomID = x.ClassroomID,
                ClassroomNumber = x.ClassroomNumber,
                Building = x.Building.BuildingName,
                NumberOfSeats = x.NumberOfSeats,
                ClassroomType = x.ClassroomType.СlassroomTypeName,
            }).ToList();


            int pageSize = 20;

            var count = model.Count();
            model = model.Skip((pageNumber) * pageSize).Take(pageSize).ToList();
            return View(new PaginatedList<ClassroomViewModel>(model, count, pageNumber, pageSize));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateClassroomViewModels()
            {
                ClassroomViewModel = new ClassroomViewModel(),
                Buildings = _mapper.Map<List<BuildingViewModel>>(_buildingService.GetAllBuildings()),
                ClassroomTypes = _mapper.Map<List<ClassroomTypeViewModel>>(_classroomTypeService.GetAllClassroomTypes()),
                SelectedBuildingIds = new List<int>(),
                SelectedClassroomTypeIds = new List<int>()
            }); ; ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateClassroomViewModels model)
        {
            if (model != null && ModelState.IsValid)
            {
                model.ClassroomViewModel.BuildingID = model.SelectedBuildingIds.First();
                model.ClassroomViewModel.ClassroomTypeID = model.SelectedClassroomTypeIds.First();
                _classroomsService.CreateClassroom(_mapper.Map<ClassroomDTO>(model.ClassroomViewModel));

                return RedirectToAction("Index", "Classroom", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<ClassroomViewModel>(_classroomsService.GetClassroomById(id));
            return View(new CreateClassroomViewModels
            {
                ClassroomViewModel = model,
                Buildings = _mapper.Map<List<BuildingViewModel>>(_buildingService.GetAllBuildings()),
                ClassroomTypes = _mapper.Map<List<ClassroomTypeViewModel>>(_classroomTypeService.GetAllClassroomTypes()),
                SelectedBuildingIds = new List<int>() { model.BuildingID },
                SelectedClassroomTypeIds = new List<int>() { model.ClassroomTypeID}
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(CreateClassroomViewModels model)
        {
            if (model != null && ModelState.IsValid)
            {
                model.ClassroomViewModel.BuildingID = model.SelectedBuildingIds.First();
                model.ClassroomViewModel.ClassroomTypeID = model.SelectedClassroomTypeIds.First();
                _classroomsService.UpdateClassroom(_mapper.Map<ClassroomDTO>(model.ClassroomViewModel));

                return RedirectToAction("Index", "Classroom", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _mapper.Map<ClassroomViewModel>(_classroomsService.GetClassroomById(id));

            return View(model);
        }

        [HttpGet]
        public ActionResult ConfirmDelete(int id)
        {
            var model = _mapper.Map<ClassroomViewModel>(_classroomsService.GetClassroomById(id));
            _classroomsService.DeleteClassroom(id);

            return RedirectToAction("Index", "Classroom", null);
        }

    }
}
