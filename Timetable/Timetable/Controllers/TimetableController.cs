using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.DataAccess;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.Web.Controllers
{
    public class TimetableController : Controller
    {
        private TimetableContext db;

        public TimetableController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.Timetables.First(x => x.ID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(TimetableApp.DataAccess.Entities.Timetable item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Timetables.Update(item);
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
        public IActionResult Delete(Timetable item)
        {
            if (ModelState.IsValid)
            {
                db.Timetables.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.Timetables.First(x => x.ID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.Timetables.ToList());
            }
            var list = db.Timetables.ToList();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Timetables.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TimetableApp.DataAccess.Entities.Timetable item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Timetables.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "TimetableApp");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
