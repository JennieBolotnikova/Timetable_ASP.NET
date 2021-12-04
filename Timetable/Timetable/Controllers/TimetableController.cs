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
        public IActionResult Index(int id, int pageNumber)
        {
            var timetable = _timetableService.GetAllTimetables().Select(x => new TimetableViewModel
            {
                ID = x.ID,
                Date = x.Date,
                Day = x.Day.DayShortName,
                LessonID = x.BellID,
                Discipline = x.Discipline.DisciplineNmae,
                ActivityType = x.ActivityType.ActivityTypesShortName,
                Group = x.Group.GroupName,
                Teacher = x.Teacher.TeacherName,
                Classroom = x.ClassroomID,
                Semester = x.Semester.SemesterTitle,

            }).ToList();
            int pageSize = 20;

            var count = timetable.Count();
            timetable = timetable.Skip((pageNumber) * pageSize).Take(pageSize).ToList();
            
            return View(new PaginatedList<TimetableViewModel>(timetable, count, pageNumber, pageSize));
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

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<TimetableViewModel>(_timetableService.GetTimetableById(id));
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(TimetableViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _timetableService.UpdateTimetable(_mapper.Map<TimetableDTO>(model));

                return RedirectToAction("Index", "Timetable", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _mapper.Map<TimetableViewModel>(_timetableService.GetTimetableById(id));

            return View(model);
        }

        [HttpGet]
        public ActionResult ConfirmDelete(int id)
        {
            var model = _mapper.Map<TimetableViewModel>(_timetableService.GetTimetableById(id));
            _timetableService.DeleteTimetable(id);

            return RedirectToAction("Index", "Timetable", null);
        }
    }
}
