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


        [HttpGet]
        public IActionResult Index(int id)
        {
            var faculty = _facultyService.GetAllFaculties().ToList();
            var model = new List<FacultyViewModel>();
            model = faculty.Select(x => new FacultyViewModel
            {
                FacultyID = x.FacultyID,
                FacultyName = x.FacultyName,
            }).ToList();
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
    }
}
