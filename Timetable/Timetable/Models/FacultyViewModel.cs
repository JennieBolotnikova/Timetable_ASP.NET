using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class FacultyViewModel
    {
        [Display(Name = "ID")]
        public int FacultyID { get; set; }

        [Display(Name = "Название факультета")]
        public string FacultyName { get; set; }
    }
}
