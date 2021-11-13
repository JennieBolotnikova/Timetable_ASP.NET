using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.DataAccess;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.Web.Controllers
{
    public class GroupController : Controller
    {
        private TimetableContext db;

        public GroupController(TimetableContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var item = db.Groups.First(x => x.GroupID == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Group item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Groups.Update(item);
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
        public IActionResult Delete(Group item)
        {
            if (ModelState.IsValid)
            {
                db.Groups.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mark = db.Groups.First(x => x.GroupID == id);
            return View(mark);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.Groups.ToList());
            }
            var list = db.Groups.ToList();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Groups.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Group item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Groups.Add(item);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                return RedirectToAction("Index", "Group");
            }

            return RedirectToAction("ErrorIndex", "Home");
        }
    }
}
