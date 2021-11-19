﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            var classrooms = _classroomsService.GetAllClassrooms().ToList();
            var model = new List<ClassroomViewModel>();
            model = classrooms.Select(x => new ClassroomViewModel
            {
                ClassroomID = x.ClassroomID,
                ClassroomNumber = x.ClassroomNumber,
                BuildingID = x.BuildingID,
                NumberOfSeats = x.NumberOfSeats,
                ClassroomTypeID = x.ClassroomTypeID,

            }).ToList();
            return View(model.AsReadOnly());
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
