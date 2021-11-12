using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.Infrastructure;
using Timetable.Core.Entities;

namespace Timetable.Web.Controllers
{
    public class ClassroomController : Controller
    {
        private TimetableContext db;

        public ClassroomController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.Classrooms.First(x => x.ClassroomID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Classroom item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Classrooms.Update(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }

        [HttpPost]
        public IActionResult Delete(Classroom item)
        {
            if (ModelState.IsValid)
            {
                db.Classrooms.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.Classrooms.First(x => x.ClassroomID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.Classrooms.ToList());
            }
            var list = db.Classrooms.ToList();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Classrooms.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Classroom item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Classrooms.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "Classroom");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
