using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.DataAccess;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.Web.Controllers
{
    public class DayController : Controller
    {
        private TimetableContext db;

        public DayController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.Days.First(x => x.DayID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Day item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Days.Update(item);
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
        public IActionResult Delete(Day item)
        {
            if (ModelState.IsValid)
            {
                db.Days.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.Days.First(x => x.DayID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.Days.ToList());
            }
            var list = db.Days.ToList();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Days.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Day item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Days.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "Day");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
