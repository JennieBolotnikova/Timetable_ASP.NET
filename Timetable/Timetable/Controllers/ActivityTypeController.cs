using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.Infrastructure;
using Timetable.Core.Entities;

namespace Timetable.Web.Controllers
{
    public class ActivityTypeController : Controller
    {
        private TimetableContext db;

        public ActivityTypeController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.ActivityTypes.First(x => x.ActivityTypeID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(ActivityType item)
        {
  
            if (ModelState.IsValid)
            {
                try
                {
                    db.ActivityTypes.Update(item);
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
        public IActionResult Delete(ActivityType item)
        {
            if (ModelState.IsValid)
            {
                db.ActivityTypes.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.ActivityTypes.First(x => x.ActivityTypeID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.ActivityTypes.ToList());
            }
            var list = db.ActivityTypes.ToList();
                
            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.ActivityTypes.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ActivityType item)
        {
 
            if (ModelState.IsValid )
            {
                try
                {
                    db.ActivityTypes.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "ActivityType");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
