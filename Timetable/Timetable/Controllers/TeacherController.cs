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
    public class TeacherController : Controller
    {
        ITeacherService _teacherService;
        private IMapper _mapper { get; set; }
        public TeacherController(ITeacherService teacherService, IMapper mapper)
        {
            _teacherService = teacherService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id, int pageNumber)
        {
            var teacher = _teacherService.GetAllTeacheres().Select(x => new TeacherViewModel
            {
               TeacherID = x.TeacherID,
               TeacherName = x.TeacherName,

            }).ToList();
            int pageSize = 20;
            var count = teacher.Count();
            teacher = teacher.Skip((pageNumber) * pageSize).Take(pageSize).ToList();
            return View(new PaginatedList<TeacherViewModel>(teacher, count, pageNumber, pageSize));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TeacherViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _teacherService.CreateTeacher(_mapper.Map<TeacherDTO>(model));

                return RedirectToAction("Index", "Teacher", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<TeacherViewModel>(_teacherService.GetTeacherById(id));
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(TeacherViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _teacherService.UpdateTeacher(_mapper.Map<TeacherDTO>(model));

                return RedirectToAction("Index", "Teacher", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _mapper.Map<TeacherViewModel>(_teacherService.GetTeacherById(id));

            return View(model);
        }

        [HttpGet]
        public ActionResult ConfirmDelete(int id)
        {
            var model = _mapper.Map<TeacherViewModel>(_teacherService.GetTeacherById(id));
            _teacherService.DeleteTeacher(id);

            return RedirectToAction("Index", "Teacher", null);
        }
    }
}
