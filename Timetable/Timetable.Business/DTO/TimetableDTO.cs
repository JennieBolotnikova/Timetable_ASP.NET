using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimetableApp.Business.DTO
{
    public class TimetableDTO
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int DayID { get; set; }
        public int BellID { get; set; }
        public int DisciplineID { get; set; }
        public int ActivityTypeID { get; set; }
        public int GroupID { get; set; }
        public int TeacherID { get; set; }
        public int ClassroomID { get; set; }
        public int SemesterID { get; set; }

        public DayDTO Day { get; set; }
        public BellDTO Bell { get; set; }
        public DisciplineDTO Discipline { get; set; }
        public ActivityTypeDTO ActivityType { get; set; }
        public GroupDTO Group { get; set; }
        public TeacherDTO Teacher { get; set; }
        public ClassroomDTO Classroom { get; set; }
        public SemesterDTO Semester { get; set; }
    }
}
