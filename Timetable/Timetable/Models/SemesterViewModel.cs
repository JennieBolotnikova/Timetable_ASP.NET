using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class SemesterViewModel
    {
        [Display(Name = "ID")]
        public int SemesterID { get; set; }

        [Display(Name = "Номер семестра")]
        public int SemesterNumber { get; set; }

        [Display(Name = "Название семестра")]
        public string SemesterTitle { get; set; }
    }
}
