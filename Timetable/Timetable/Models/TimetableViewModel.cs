using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class TimetableViewModel
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Display(Name = "День нелели")]
        public int DayID { get; set; }

        [Display(Name = "Номер пары")]
        public int LessonID { get; set; }

        [Display(Name = "Дисциплина")]
        public int DisciplineID { get; set; }

        [Display(Name = "Вид занятости")]
        public int ActivityTypeID { get; set; }

        [Display(Name = "Группа")]
        public int GroupID { get; set; }

        [Display(Name = "Преподаватель")]
        public int TeacherID { get; set; }

        [Display(Name = "Номер аудитории")]
        public int ClassroomID { get; set; }

        [Display(Name = "Семестр")]
        public int SemesterID { get; set; }
    }
}
