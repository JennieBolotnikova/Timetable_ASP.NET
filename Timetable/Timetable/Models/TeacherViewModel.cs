using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class TeacherViewModel
    {
        [Display(Name = "ID")]
        public int TeacherID { get; set; }

        [Display(Name = "ФИО преподавателя")]
        public string TeacherName { get; set; }
    }
}
