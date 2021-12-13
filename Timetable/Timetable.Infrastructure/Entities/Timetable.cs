using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimetableApp.DataAccess.Entities
{
    public class Timetable
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

        public Day Day { get; set; }
        public Bell Bell { get; set; }
        public Discipline Discipline { get; set; }
        public ActivityType ActivityType { get; set; }
        public Group Group { get; set; }
        public Teacher Teacher { get; set; }
        public Classroom Classroom { get; set; }
        public Semester Semester { get; set; }


    }
}
