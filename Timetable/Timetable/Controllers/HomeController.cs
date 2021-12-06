using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp;

namespace TimetableApp.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult TeacherTimetable()
        {
            return RedirectToAction("ByTeachers", "Timetable");
        }

        public IActionResult ClassroomTimetable()
        {
            return RedirectToAction("ByClassrooms", "Timetable");
        }

        public IActionResult GroupTimetable()
        {
            return RedirectToAction("ByGroups", "Timetable");
        }
    }
}
