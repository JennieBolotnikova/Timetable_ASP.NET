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
        IFacultyService _facultyService;
        private IMapper _mapper { get; set; }
        public GroupController(IGroupService groupService, IFacultyService facultyService, IMapper mapper)
        {
            _groupService = groupService;
            _facultyService = facultyService;
            _mapper = mapper;
        }


      
        public IActionResult Index(int id, int pageNumber, string searchString)
        {
            var group = _groupService.GetAllGroups().Select(x => new GroupViewModel
            {
                GroupID = x.GroupID,
                GroupName = x.GroupName,
                GroupNumber = x.GroupNumber,
                Faculty = x.Faculty.FacultyName,
                NumberOfStudents = x.NumberOfStudents,
   
            });

            if (!String.IsNullOrEmpty(searchString))
            {
                group = group.Where(s => s.GroupName!.Contains(searchString));
            }
            int pageSize = 20;

            var count = group.Count();
            group = group.Skip((pageNumber) * pageSize).Take(pageSize).ToList();

            return View(new PaginatedList<GroupViewModel>(group.ToList(), count, pageNumber, pageSize));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateGroupViewModel()
            {
                GroupViewModel = new GroupViewModel(),
                Faculties = _mapper.Map<List<FacultyViewModel>>(_facultyService.GetAllFaculties()),
                SelectedFacultyIds = new List<int>()
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateGroupViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                model.GroupViewModel.FacultyID = model.SelectedFacultyIds.First();
                _groupService.CreateGroup(_mapper.Map<GroupDTO>(model.GroupViewModel));               
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<GroupViewModel>(_groupService.GetGroupById(id));
            return View(new CreateGroupViewModel
            {
                GroupViewModel = model,
                Faculties = _mapper.Map<List<FacultyViewModel>>(_facultyService.GetAllFaculties()),
                SelectedFacultyIds = new List<int>() { model.FacultyID}
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(CreateGroupViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                model.GroupViewModel.FacultyID = model.SelectedFacultyIds.First();
                _groupService.UpdateGroup(_mapper.Map<GroupDTO>(model.GroupViewModel));

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
