using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.Business.IServices;
using AutoMapper;
using TimetableApp.Web.Models;

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
    }
}
