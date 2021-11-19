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
    public class BellController : Controller
    {
        IBellService _bellTypeService;
        private IMapper _mapper { get; set; }
        public BellController(IBellService bellTypeService, IMapper mapper)
        {
            _bellTypeService = bellTypeService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id)
        {
            var bells = _bellTypeService.GetAllBells().ToList();
            var model = new List<BellViewModel>();
            model = bells.Select(x => new BellViewModel
            {
                BellID = x.BellID,
                LessonStartTime = x.LessonStartTime,
                LessonEndTime = x.LessonEndTime,
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
        public IActionResult Create(BellViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _bellTypeService.CreateBell(_mapper.Map<BellDTO>(model));

                return RedirectToAction("Index", "Bell", null);
            }

            return View(model);
        }
    }
}
