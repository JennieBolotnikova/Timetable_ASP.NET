using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class DisciplineViewModel
    {
        [Display(Name = "ID")]
        public int DisciplineID { get; set; }

        [Display(Name = "Название дисциплины")]
        public string DisciplineNmae { get; set; }
    }
}
