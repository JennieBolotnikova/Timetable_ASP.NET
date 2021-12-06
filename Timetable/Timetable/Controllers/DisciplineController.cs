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


       
        public IActionResult Index(int id, int pageNumber, string searchString)
        {         
            var discipline = _disciplineService.GetAllDisciplines().Select(x => new DisciplineViewModel
            {
                DisciplineID = x.DisciplineID,
                DisciplineNmae = x.DisciplineNmae,
            });

            if (!String.IsNullOrEmpty(searchString))
            {
                discipline = discipline.Where(s => s.DisciplineNmae!.Contains(searchString));
            }
            int pageSize = 20;

            var count = discipline.Count();
            discipline = discipline.Skip((pageNumber) * pageSize).Take(pageSize).ToList();

            return View(new PaginatedList<DisciplineViewModel>(discipline.ToList(), count, pageNumber, pageSize));

           
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
