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
    public class SemesterController : Controller
    {
        ISemesterService _semesterService;
        private IMapper _mapper { get; set; }
        public SemesterController(ISemesterService semesterService, IMapper mapper)
        {
            _semesterService = semesterService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id)
        {
            var group = _semesterService.GetAllSemesters().ToList();
            var model = new List<SemesterViewModel>();
            model = group.Select(x => new SemesterViewModel
            {
               SemesterID = x.SemesterID,
               SemesterNumber = x.SemesterNumber,
               SemesterTitle = x.SemesterTitle,

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
        public IActionResult Create(SemesterViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _semesterService.CreateSemester(_mapper.Map<SemesterDTO>(model));

                return RedirectToAction("Index", "Semester", null);
            }

            return View(model);
        }
    }
}
