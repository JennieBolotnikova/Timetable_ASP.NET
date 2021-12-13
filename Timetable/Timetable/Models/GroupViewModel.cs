using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class GroupViewModel
    {
        [Display(Name = "ID")]
        public int GroupID { get; set; }

        [Display(Name = "Название группы")]
        public string GroupName { get; set; }

        [Display(Name = "Номер группы")]
        public int GroupNumber { get; set; }
    
        public int FacultyID { get; set; }

        [Display(Name = "Факультет")]
        public string Faculty { get; set; }

        [Display(Name = "Количество студентов")]
        public int NumberOfStudents { get; set; }
    }
}
