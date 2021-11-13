using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.DataAccess;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.Web.Controllers
{
    public class FacultyController : Controller
    {
        private TimetableContext db;

        public FacultyController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.Faculties.First(x => x.FacultyID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Faculty item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Faculties.Update(item);
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
        public IActionResult Delete(Faculty item)
        {
            if (ModelState.IsValid)
            {
                db.Faculties.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.Faculties.First(x => x.FacultyID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.Faculties.ToList());
            }
            var list = db.Faculties.ToList();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Faculties.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Faculty item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Faculties.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "Faculty");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
