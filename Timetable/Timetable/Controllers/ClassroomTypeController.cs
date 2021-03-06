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
using TimetableApp.Business.DTO;

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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClassroomTypeViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _classroomTypeService.CreateClassroomType(_mapper.Map<ClassroomTypeDTO>(model));

                return RedirectToAction("Index", "ClassroomType", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<ClassroomTypeViewModel>(_classroomTypeService.GetClassroomTypeById(id));
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(ClassroomTypeViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _classroomTypeService.UpdateClassroomType(_mapper.Map<ClassroomTypeDTO>(model));

                return RedirectToAction("Index", "ClassroomType", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _mapper.Map<ClassroomTypeViewModel>(_classroomTypeService.GetClassroomTypeById(id));

            return View(model);
        }

        [HttpGet]
        public ActionResult ConfirmDelete(int id)
        {
            var model = _mapper.Map<ClassroomTypeViewModel>(_classroomTypeService.GetClassroomTypeById(id));
            _classroomTypeService.DeleteClassroomType(id);

            return RedirectToAction("Index", "ClassroomType", null);
        }
    }
}
