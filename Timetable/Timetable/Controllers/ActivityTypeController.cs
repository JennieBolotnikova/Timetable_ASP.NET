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
    public class ActivityTypeController : Controller
    {
        IActivityTypeService _activityTypeService;
        private IMapper _mapper { get; set; } 
        public ActivityTypeController(IActivityTypeService activityTypeService, IMapper mapper)
        {
            _activityTypeService = activityTypeService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id)
        {
            var activites = _activityTypeService.GetAllActivityTypes().ToList();
            var model = new List<ActivityTypeViewModel>();
            model = activites.Select(x => new ActivityTypeViewModel
            {
                ActivityTypeID = x.ActivityTypeID,
                ActivityTypeName = x.ActivityTypeName,
                ActivityTypesShortName = x.ActivityTypesShortName,
            }).ToList();
            return View(model.AsReadOnly());
        }

       
    }
}
