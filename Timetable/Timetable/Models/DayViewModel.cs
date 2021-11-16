using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class DayViewModel
    {
        [Display(Name = "ID")]
        public int DayID { get; set; }

        [Display(Name = "День")]
        public string DayName { get; set; }

        [Display(Name = "Короткое название")]
        public string DayShortName { get; set; }
    }
}
