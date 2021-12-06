using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimetableApp.Web.Models
{
    public class CreateTimetableViewModel
    {
        public TimetableViewModel TimetableViewModel { get; set; }
        public List<DayViewModel> Days { get; set; }
        public List<BellViewModel> Bells { get; set; }
        public List<DisciplineViewModel> Disciplines { get; set; }
        public List<ActivityTypeViewModel> ActivityTypes { get; set; }
        public List<GroupViewModel> Groups { get; set; }
        public List<TeacherViewModel> Teachers { get; set; }
        public List<ClassroomViewModel> Classrooms { get; set; }
        public List<SemesterViewModel> Semesters { get; set; }
        
        public IEnumerable<int> SelectedDayIds { get; set; }
        public IEnumerable<int> SelectedBellIds { get; set; }
        public IEnumerable<int> SelectedDisciplineIds { get; set; }
        public IEnumerable<int> SelectedActivityTypeIds { get; set; }
        public IEnumerable<int> SelectedGroupIds { get; set; }
        public IEnumerable<int> SelectedTeacherIds { get; set; }
        public IEnumerable<int> SelectedClassroomIds { get; set; }
        public IEnumerable<int> SelectedSemesterIds { get; set; }
    }
}
