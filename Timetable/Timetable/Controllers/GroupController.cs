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
    public class GroupController : Controller
    {
        IGroupService _groupService;
        private IMapper _mapper { get; set; }
        public GroupController(IGroupService facultyService, IMapper mapper)
        {
            _groupService = facultyService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id)
        {
            var group = _groupService.GetAllGroups().ToList();
            var model = new List<GroupViewModel>();
            model = group.Select(x => new GroupViewModel
            {
                GroupID = x.GroupID,
                GroupName = x.GroupName,
                GroupNumber = x.GroupNumber,
                FacultyID = x.FacultyID,
                NumberOfStudents = x.NumberOfStudents,
   
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
        public IActionResult Create(GroupViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _groupService.CreateGroup(_mapper.Map<GroupDTO>(model));

                return RedirectToAction("Index", "Group", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<GroupViewModel>(_groupService.GetGroupById(id));
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(GroupViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _groupService.UpdateGroup(_mapper.Map<GroupDTO>(model));

                return RedirectToAction("Index", "Group", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _mapper.Map<GroupViewModel>(_groupService.GetGroupById(id));

            return View(model);
        }

        [HttpGet]
        public ActionResult ConfirmDelete(int id)
        {
            var model = _mapper.Map<GroupViewModel>(_groupService.GetGroupById(id));
            _groupService.DeleteGroup(id);

            return RedirectToAction("Index", "Group", null);
        }
    }
}
