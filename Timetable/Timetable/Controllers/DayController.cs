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
    public class DayController : Controller
    {
        IDayService _dayService;
        private IMapper _mapper { get; set; }
        public DayController(IDayService dayService, IMapper mapper)
        {
            _dayService = dayService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id)
        {
            var day = _dayService.GetAllDays().ToList();
            var model = new List<DayViewModel>();
            model = day.Select(x => new DayViewModel
            {
                DayID = x.DayID,
                DayName = x.DayName,
                DayShortName = x.DayShortName,
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
        public IActionResult Create(DayViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _dayService.CreateDay(_mapper.Map<DayDTO>(model));

                return RedirectToAction("Index", "Day", null);
            }

            return View(model);
        }
    }
}
