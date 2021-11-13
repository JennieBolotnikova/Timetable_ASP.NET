using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.DataAccess;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.Controllers
{
    public class BuildingController : Controller
    {
        private TimetableContext db;

        public BuildingController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.Buildings.First(x => x.BuildingID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Building item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Buildings.Update(item);
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
        public IActionResult Delete(Building item)
        {
            if (ModelState.IsValid)
            {
                db.Buildings.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.Buildings.First(x => x.BuildingID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.Buildings.ToList());
            }
            var list = db.Buildings.ToList();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Buildings.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Building item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Buildings.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "Building");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
