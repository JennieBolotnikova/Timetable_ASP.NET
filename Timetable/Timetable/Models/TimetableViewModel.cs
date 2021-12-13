using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TimetableApp.Web.Models
{
    public class TimetableViewModel
    {
        public int ID { get; set; }
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        public int DayID { get; set; }
        public int BellID { get; set; }
        public int DisciplineID { get; set; }
        public int ActivityTypeID { get; set; }
        public int GroupID { get; set; }
        public int TeacherID { get; set; }
        public int ClassroomID { get; set; }
        public int SemesterID { get; set; }


        [Display(Name = "День нелели")]
        public string Day { get; set; }
        [Display(Name = "Начало пары")]
        public string Bell { get; set; }
        [Display(Name = "Дисциплина")]
        public string Discipline { get; set; }
        [Display(Name = "Вид занятости")]
        public string ActivityType { get; set; }
        [Display(Name = "Группа")]
        public string Group { get; set; }
        [Display(Name = "Преподаватель")]
        public string Teacher { get; set; }
        [Display(Name = "Номер аудитории")]
        public string Classroom { get; set; }
        [Display(Name = "Семестр")]
        public string Semester { get; set; }

    }
}
