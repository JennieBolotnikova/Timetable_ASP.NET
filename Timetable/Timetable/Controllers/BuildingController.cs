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
    }
}
