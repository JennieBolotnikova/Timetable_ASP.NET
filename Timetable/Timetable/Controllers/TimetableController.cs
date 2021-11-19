using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.Business.IServices;
using AutoMapper;
using TimetableApp.Web.Models;
using TimetableApp.Business.DTO;

namespace TimetableApp.Web.Controllers
{
    public class TimetableController : Controller
    {
        ITimetableService _timetableService;
        private IMapper _mapper { get; set; }
        public TimetableController(ITimetableService timetableService, IMapper mapper)
        {
            _timetableService = timetableService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id)
        {
            var teacher = _timetableService.GetAllTimetables().ToList();
            var model = new List<TimetableViewModel>();
            model = teacher.Select(x => new TimetableViewModel
            {
                ID = x.ID,
                Date = x.Date,
                DayID = x.DayID,
                LessonID = x.LessonID,
                DisciplineID = x.DisciplineID,
                ActivityTypeID = x.ActivityTypeID,
                GroupID = x.GroupID,
                TeacherID = x.TeacherID,
                ClassroomID = x.ClassroomID,
                SemesterID = x.SemesterID,

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
        public IActionResult Create(TimetableViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _timetableService.CreateTimetable(_mapper.Map<TimetableDTO>(model));

                return RedirectToAction("Index", "Timetable", null);
            }

            return View(model);
        }
    }
}
