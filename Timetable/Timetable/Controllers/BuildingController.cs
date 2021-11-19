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

namespace TimetableApp.Controllers
{
    public class BuildingController : Controller
    {
        IBuildingService _buildingService;
        private IMapper _mapper { get; set; }
        public BuildingController(IBuildingService buildingService, IMapper mapper)
        {
            _buildingService = buildingService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id)
        {
            var b = _buildingService.GetAllBuildings().ToList();
            var model = new List<BuildingViewModel>();
            model = b.Select(x => new BuildingViewModel
            {
                BuildingID = x.BuildingID,
                BuildingName = x.BuildingName,
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
        public IActionResult Create(BuildingViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _buildingService.CreateBuilding(_mapper.Map<BuildingDTO>(model));

                return RedirectToAction("Index", "Building", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<BuildingViewModel>(_buildingService.GetBuildingById(id));
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(BuildingViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _buildingService.UpdateBuilding(_mapper.Map<BuildingDTO>(model));

                return RedirectToAction("Index", "Building", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _mapper.Map<BuildingViewModel>(_buildingService.GetBuildingById(id));

            return View(model);
        }

        [HttpGet]
        public ActionResult ConfirmDelete(int id)
        {
            var model = _mapper.Map<BuildingViewModel>(_buildingService.GetBuildingById(id));
            _buildingService.DeleteBuilding(id);

            return RedirectToAction("Index", "Building", null);
        }
    }
}
