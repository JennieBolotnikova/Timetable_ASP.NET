using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.Business.IServices;
using AutoMapper;
using TimetableApp.Web.Models;
using TimetableApp.Business.DTO;

namespace TimetableApp.Web.Controllers
{
    public class FacultyController : Controller
    {
        IFacultyService _facultyService;
        private IMapper _mapper { get; set; }
        public FacultyController(IFacultyService facultyService, IMapper mapper)
        {
            _facultyService = facultyService;
            _mapper = mapper;
        }


       
        public IActionResult Index(int id, string searchString)
        {
            var faculty = _facultyService.GetAllFaculties().ToList();
            var model = new List<FacultyViewModel>();
            model = faculty.Select(x => new FacultyViewModel
            {
                FacultyID = x.FacultyID,
                FacultyName = x.FacultyName,
            }).ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                model = model.Where(s => s.FacultyName!.Contains(searchString)).ToList();
            }
            return View(model.AsReadOnly());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FacultyViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _facultyService.CreateFaculty(_mapper.Map<FacultyDTO>(model));

                return RedirectToAction("Index", "Faculty", null);
            }

            return View(model);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<FacultyViewModel>(_facultyService.GetFacultyById(id));
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(FacultyViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _facultyService.UpdateFaculty(_mapper.Map<FacultyDTO>(model));

                return RedirectToAction("Index", "Faculty", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _mapper.Map<FacultyViewModel>(_facultyService.GetFacultyById(id));

            return View(model);
        }

        [HttpGet]
        public ActionResult ConfirmDelete(int id)
        {
            var model = _mapper.Map<FacultyViewModel>(_facultyService.GetFacultyById(id));
            _facultyService.DeleteFaculty(id);

            return RedirectToAction("Index", "Faculty", null);
        }
    }
}
