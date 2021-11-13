using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.DataAccess;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.Web.Controllers
{
    public class ClassroomTypeController : Controller
    {
        private TimetableContext db;

        public ClassroomTypeController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.ClassroomTypes.First(x => x.ClassroomTypeID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(ClassroomType item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.ClassroomTypes.Update(item);
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
        public IActionResult Delete(ClassroomType item)
        {
            if (ModelState.IsValid)
            {
                db.ClassroomTypes.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.ClassroomTypes.First(x => x.ClassroomTypeID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.ClassroomTypes.ToList());
            }
            var list = db.ClassroomTypes.ToList();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.ClassroomTypes.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClassroomType item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.ClassroomTypes.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "ClassroomType");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
