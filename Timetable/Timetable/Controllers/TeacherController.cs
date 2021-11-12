using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.Infrastructure;
using Timetable.Core.Entities;

namespace Timetable.Web.Controllers
{
    public class TeacherController : Controller
    {
        private TimetableContext db;

        public TeacherController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.Teachers.First(x => x.TeacherID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Teacher item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Teachers.Update(item);
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
        public IActionResult Delete(Teacher item)
        {
            if (ModelState.IsValid)
            {
                db.Teachers.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.Teachers.First(x => x.TeacherID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.Teachers.ToList());
            }
            var list = db.Teachers.ToList();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Teachers.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Teacher item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Teachers.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "Teacher");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
