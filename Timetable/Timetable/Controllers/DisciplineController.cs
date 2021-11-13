using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.DataAccess;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.Web.Controllers
{
    public class DisciplineController : Controller
    {
        private TimetableContext db;

        public DisciplineController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.Disciplines.First(x => x.DisciplineID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Discipline item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Disciplines.Update(item);
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
        public IActionResult Delete(Discipline item)
        {
            if (ModelState.IsValid)
            {
                db.Disciplines.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.Disciplines.First(x => x.DisciplineID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.Disciplines.ToList());
            }
            var list = db.Disciplines.ToList();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Disciplines.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Discipline item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Disciplines.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "Discipline");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
