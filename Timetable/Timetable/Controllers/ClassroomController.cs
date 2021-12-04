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
        private IMapper _mapper { get; set; }
        public ClassroomController(IClassroomsService classroomsService, IMapper mapper)
        {
            _classroomsService = classroomsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber)
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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClassroomViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _classroomsService.CreateClassroom(_mapper.Map<ClassroomDTO>(model));

                return RedirectToAction("Index", "Classroom", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<ClassroomViewModel>(_classroomsService.GetClassroomById(id));
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(ClassroomViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _classroomsService.UpdateClassroom(_mapper.Map<ClassroomDTO>(model));

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
