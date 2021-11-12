using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.Infrastructure;
using Timetable.Core.Entities;

namespace Timetable.Web.Controllers
{
    public class BellController : Controller
    {
        private TimetableContext db;

        public BellController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.Bells.First(x => x.BellID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Bell item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Bells.Update(item);
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
        public IActionResult Delete(Bell item)
        {
            if (ModelState.IsValid)
            {
                db.Bells.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.Bells.First(x => x.BellID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.Bells.ToList());
            }
            var list = db.Bells.ToList();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Bells.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Bell item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Bells.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "Bell");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
