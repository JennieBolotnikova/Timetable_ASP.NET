using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.DataAccess;
using TimetableApp.DataAccess.Entities;
using TimetableApp.Business.IServices;
using AutoMapper;
using TimetableApp.Web.Models;

namespace TimetableApp.Web.Controllers
{
    public class ClassroomTypeController : Controller
    {
        IClassroomTypeService _classroomTypeService;
        private IMapper _mapper { get; set; }
        public ClassroomTypeController(IClassroomTypeService classroomTypeService, IMapper mapper)
        {
            _classroomTypeService = classroomTypeService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id)
        {
            var classroomTypes = _classroomTypeService.GetAllClassroomTypes().ToList();
            var model = new List<ClassroomTypeViewModel>();
            model = classroomTypes.Select(x => new ClassroomTypeViewModel
            {
                ClassroomTypeID = x.ClassroomTypeID,
                СlassroomTypeName = x.СlassroomTypeName,
            }).ToList();
            return View(model.AsReadOnly());
        }
    }
}
