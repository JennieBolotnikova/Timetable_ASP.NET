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
    public class DisciplineController : Controller
    {
        IDisciplineService _disciplineService;
        private IMapper _mapper { get; set; }
        public DisciplineController(IDisciplineService disciplineService, IMapper mapper)
        {
            _disciplineService = disciplineService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id)
        {
            var discipline = _disciplineService.GetAllDisciplines().ToList();
            var model = new List<DisciplineViewModel>();
            model = discipline.Select(x => new DisciplineViewModel
            {
                DisciplineID = x.DisciplineID,
                DisciplineNmae = x.DisciplineNmae,
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
        public IActionResult Create(DisciplineViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _disciplineService.CreateDiscipline(_mapper.Map<DisciplineDTO>(model));

                return RedirectToAction("Index", "Discipline", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<DisciplineViewModel>(_disciplineService.GetDisciplineById(id));
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(DisciplineViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _disciplineService.UpdateDiscipline(_mapper.Map<DisciplineDTO>(model));

                return RedirectToAction("Index", "Discipline", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _mapper.Map<DisciplineViewModel>(_disciplineService.GetDisciplineById(id));

            return View(model);
        }

        [HttpGet]
        public ActionResult ConfirmDelete(int id)
        {
            var model = _mapper.Map<DisciplineViewModel>(_disciplineService.GetDisciplineById(id));
            _disciplineService.DeleteDiscipline(id);

            return RedirectToAction("Index", "Discipline", null);
        }
    }
}
