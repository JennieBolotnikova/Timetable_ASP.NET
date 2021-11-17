using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.Business.IServices;
using AutoMapper;
using TimetableApp.Web.Models;

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
        public IActionResult Index(int id)
        {
            var teacher = _teacherService.GetAllTeacheres().ToList();
            var model = new List<TeacherViewModel>();
            model = teacher.Select(x => new TeacherViewModel
            {
               TeacherID = x.TeacherID,
               TeacherName = x.TeacherName,

            }).ToList();
            return View(model.AsReadOnly());
        }
    }
}
