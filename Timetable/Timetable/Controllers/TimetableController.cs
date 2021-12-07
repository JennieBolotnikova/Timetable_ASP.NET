using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableApp.Business.IServices;
using AutoMapper;
using TimetableApp.Web.Models;
using TimetableApp.Business.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TimetableApp.Web.Controllers
{
    public class TimetableController : Controller
    {
        ITimetableService _timetableService;
        IDayService _dayService;
        IBellService _bellService;
        IClassroomsService _classroomsService;
        IDisciplineService _disciplineService;
        IActivityTypeService _activityTypeService;
        IGroupService _groupService;
        ITeacherService _teacherService;
        ISemesterService _semesterService;
        private IMapper _mapper { get; set; }
        public TimetableController(ITimetableService timetableService, IDayService dayService, IBellService bellService,
            IClassroomsService classroomsService, IDisciplineService disciplineService, IActivityTypeService activityTypeService,
            IGroupService groupService, ITeacherService teacherService, ISemesterService semesterService, IMapper mapper)
        {
            _timetableService = timetableService;
            _dayService = dayService;
            _bellService = bellService;
            _classroomsService = classroomsService;
            _disciplineService = disciplineService;
            _activityTypeService = activityTypeService;
            _groupService = groupService;
            _teacherService = teacherService;
            _semesterService = semesterService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index(int id, int pageNumber, string sortOrder)
        {
            ViewBag.DaySortParm = String.IsNullOrEmpty(sortOrder) ? "Day" : "";
            ViewBag.DateSortParm = sortOrder == "Date";
            ViewBag.DisciplineSortParm = String.IsNullOrEmpty(sortOrder) ? "Discipline" : "";
            ViewBag.ActivityTypeSortParm = String.IsNullOrEmpty(sortOrder) ? "ActivityType" : "";
            ViewBag.GroupSortParm = String.IsNullOrEmpty(sortOrder) ? "Group" : "";
            ViewBag.TeacherSortParm = String.IsNullOrEmpty(sortOrder) ? "Teacher" : "";
            ViewBag.ClassroomSortParm = String.IsNullOrEmpty(sortOrder) ? "Classroom" : "";
            ViewBag.SemesterSortParm = String.IsNullOrEmpty(sortOrder) ? "Semester" : "";

            var timetable = _timetableService.GetAllTimetables().Select(x => new TimetableViewModel
            {
                ID = x.ID,
                Date = x.Date,
                Day = x.Day.DayShortName,
                BellID = x.BellID,
                Discipline = x.Discipline.DisciplineNmae,
                ActivityType = x.ActivityType.ActivityTypesShortName,
                Group = x.Group.GroupName,
                Teacher = x.Teacher.TeacherName,
                Classroom = x.ClassroomID,
                Semester = x.Semester.SemesterTitle,

            });

            switch (sortOrder)
            {
                case "Day":
                    timetable = timetable.OrderBy(s => s.Day);
                    break;
                case "Date":
                    timetable = timetable.OrderBy(s => s.Date);
                    break;
                case "Discipline":
                    timetable = timetable.OrderBy(s => s.Discipline);
                    break;
                case "ActivityType":
                    timetable = timetable.OrderBy(s => s.ActivityType);
                    break;
                case "Group":
                    timetable = timetable.OrderBy(s => s.Group);
                    break;
                case "Teacher":
                    timetable = timetable.OrderBy(s => s.Teacher);
                    break;
                case "Classroom":
                    timetable = timetable.OrderBy(s => s.Classroom);
                    break;
                case "Semester":
                    timetable = timetable.OrderBy(s => s.Semester);
                    break;
            }
            int pageSize = 20;

            var count = timetable.Count();
   
            timetable = timetable.Skip((pageNumber) * pageSize).Take(pageSize);
            
            return View(new PaginatedList<TimetableViewModel>(timetable.ToList(), count, pageNumber, pageSize));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateTimetableViewModel()
            {
                TimetableViewModel = new TimetableViewModel(),
                Days = _mapper.Map<List<DayViewModel>>(_dayService.GetAllDays()),
                Bells = _mapper.Map<List<BellViewModel>>(_bellService.GetAllBells()),
                Disciplines = _mapper.Map<List<DisciplineViewModel>>(_disciplineService.GetAllDisciplines()),
                ActivityTypes = _mapper.Map<List< ActivityTypeViewModel >>(_activityTypeService.GetAllActivityTypes()),
                Groups = _mapper.Map<List<GroupViewModel>>(_groupService.GetAllGroups()),
                Teachers = _mapper.Map<List<TeacherViewModel>>(_teacherService.GetAllTeacheres()),
                Classrooms = _mapper.Map<List<ClassroomViewModel>>(_classroomsService.GetAllClassrooms()),
                Semesters = _mapper.Map<List<SemesterViewModel>>(_semesterService.GetAllSemesters()),

            }) ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateTimetableViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                model.TimetableViewModel.DayID = model.SelectedDayIds.First();
                model.TimetableViewModel.BellID = model.SelectedBellIds.First();
                model.TimetableViewModel.DisciplineID = model.SelectedDisciplineIds.First();
                model.TimetableViewModel.ActivityTypeID = model.SelectedActivityTypeIds.First();
                model.TimetableViewModel.GroupID = model.SelectedGroupIds.First();
                model.TimetableViewModel.TeacherID = model.SelectedTeacherIds.First();
                model.TimetableViewModel.ClassroomID = model.SelectedClassroomIds.First();
                model.TimetableViewModel.SemesterID = model.SelectedSemesterIds.First();
                _timetableService.CreateTimetable(_mapper.Map<TimetableDTO>(model.TimetableViewModel));  
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var model = _mapper.Map<TimetableViewModel>(_timetableService.GetTimetableById(id));
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(TimetableViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                _timetableService.UpdateTimetable(_mapper.Map<TimetableDTO>(model));

                return RedirectToAction("Index", "Timetable", null);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _mapper.Map<TimetableViewModel>(_timetableService.GetTimetableById(id));

            return View(model);
        }

        [HttpGet]
        public ActionResult ConfirmDelete(int id)
        {
            var model = _mapper.Map<TimetableViewModel>(_timetableService.GetTimetableById(id));
            _timetableService.DeleteTimetable(id);

            return RedirectToAction("Index", "Timetable", null);
        }

        public ActionResult ByTeachers(int id, int pageNumber, string searchString, string semesters)
        {
            
            var timetable = _timetableService.GetAllTimetables().Select(x => new TimetableViewModel
            {
                ID = x.ID,
                Date = x.Date,
                Day = x.Day.DayShortName,
                BellID = x.BellID,
                Discipline = x.Discipline.DisciplineNmae,
                ActivityType = x.ActivityType.ActivityTypesShortName,
                Group = x.Group.GroupName,
                Teacher = x.Teacher.TeacherName,
                Classroom = x.ClassroomID,
                Semester = x.Semester.SemesterTitle,

            });

            timetable = timetable.OrderBy(s => s.Teacher);
            if (!String.IsNullOrEmpty(searchString))
            {
                timetable = timetable.Where(s => s.Teacher!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(semesters))
            {
                timetable = timetable.Where(x => x.Semester == semesters);
            }
         
            int pageSize = 20;

            var count = timetable.Count();
            timetable = timetable.Skip((pageNumber) * pageSize).Take(pageSize).ToList();

            return View(new PaginatedList<TimetableViewModel>(timetable.ToList(), count, pageNumber, pageSize));
        }

        public ActionResult ByClassrooms(int id, int pageNumber, int searchString)
        {
            var timetable = _timetableService.GetAllTimetables().Select(x => new TimetableViewModel
            {
                ID = x.ID,
                Date = x.Date,
                Day = x.Day.DayShortName,
                BellID = x.BellID,
                Discipline = x.Discipline.DisciplineNmae,
                ActivityType = x.ActivityType.ActivityTypesShortName,
                Group = x.Group.GroupName,
                Teacher = x.Teacher.TeacherName,
                Classroom = x.ClassroomID,
                Semester = x.Semester.SemesterTitle,

            });

            if (searchString != 0)
            {
                timetable = timetable.Where(s => s.Classroom == searchString);
            }
            int pageSize = 20;

            var count = timetable.Count();
            timetable = timetable.Skip((pageNumber) * pageSize).Take(pageSize).ToList();

            return View(new PaginatedList<TimetableViewModel>(timetable.ToList(), count, pageNumber, pageSize));
        }

        public ActionResult ByGroups(int id, int pageNumber, string searchString)
        {
            var timetable = _timetableService.GetAllTimetables().Select(x => new TimetableViewModel
            {
                ID = x.ID,
                Date = x.Date,
                Day = x.Day.DayShortName,
                BellID = x.BellID,
                Discipline = x.Discipline.DisciplineNmae,
                ActivityType = x.ActivityType.ActivityTypesShortName,
                Group = x.Group.GroupName,
                Teacher = x.Teacher.TeacherName,
                Classroom = x.ClassroomID,
                Semester = x.Semester.SemesterTitle,

            });

            if (!String.IsNullOrEmpty(searchString))
            {
                timetable = timetable.Where(s => s.Group!.Contains(searchString));
            }
            int pageSize = 20;

            var count = timetable.Count();
            timetable = timetable.Skip((pageNumber) * pageSize).Take(pageSize).ToList();

            return View(new PaginatedList<TimetableViewModel>(timetable.ToList(), count, pageNumber, pageSize));
        }
    }
}
