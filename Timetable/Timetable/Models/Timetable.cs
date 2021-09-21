using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.Models
{
    public class Timetable
    {
        public Timetable(int iD, DateTime date, int dayID, int lessonID, int disciplineID, int activityTypeID, int groupID, int teacherID, int сlassroomID)
        {
            ID = iD;
            Date = date;
            DayID = dayID;
            LessonID = lessonID;
            DisciplineID = disciplineID;
            ActivityTypeID = activityTypeID;
            GroupID = groupID;
            TeacherID = teacherID;
            СlassroomID = сlassroomID;
        }

        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int DayID { get; set; }
        public int LessonID { get; set; }
        public int DisciplineID { get; set; }
        public int ActivityTypeID { get; set; }
        public int GroupID { get; set; }
        public int TeacherID { get; set; }
        public int СlassroomID { get; set; }
    }
}
