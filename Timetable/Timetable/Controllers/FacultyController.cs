using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.Business.IServices;
using AutoMapper;
using TimetableApp.Web.Models;

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
    }
}
