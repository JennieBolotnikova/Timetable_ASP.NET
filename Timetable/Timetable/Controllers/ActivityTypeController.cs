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
    public class ActivityTypeController : Controller
    {
        IActivityTypeService _activityTypeService;
        private IMapper _mapper { get; set; } 
        public ActivityTypeController(IActivityTypeService activityTypeService, IMapper mapper)
        {
            _activityTypeService = activityTypeService;
            _mapper = mapper;
        }



        public IActionResult Index(int id, string searchString)
        {
            var activites = _activityTypeService.GetAllActivityTypes().Select(x => new ActivityTypeViewModel
            {
                ActivityTypeID = x.ActivityTypeID,
                ActivityTypeName = x.ActivityTypeName,
                ActivityTypesShortName = x.ActivityTypesShortName,
            });
            if (!String.IsNullOrEmpty(searchString))
            {
                activites = activites.Where(s => s.ActivityTypeName!.Contains(searchString));
            }
            return View(activites.ToList().AsReadOnly());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ActivityTypeViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _activityTypeService.CreateActivityType(_mapper.Map<ActivityTypeDTO>(model));

                return RedirectToAction("Index", "ActivityType", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<ActivityTypeViewModel>(_activityTypeService.GetActivityTypeById(id));
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(ActivityTypeViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _activityTypeService.UpdateActivityType(_mapper.Map<ActivityTypeDTO>(model));

                return RedirectToAction("Index", "ActivityType", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _mapper.Map<ActivityTypeViewModel>(_activityTypeService.GetActivityTypeById(id));

            return View(model);
        }

        [HttpGet]
        public ActionResult ConfirmDelete(int id)
        {
            var model = _mapper.Map<ActivityTypeViewModel>(_activityTypeService.GetActivityTypeById(id));
            _activityTypeService.DeleteActivityType(id);

            return RedirectToAction("Index", "ActivityType", null);
        }


    }
}
