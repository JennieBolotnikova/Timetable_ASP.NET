using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class ClassroomTypeViewModel
    {
        [Display(Name = "ID")]
        public int ClassroomTypeID { get; set; }

        [Display(Name = "Тип аудитории")]
        public string СlassroomTypeName { get; set; }
    }
}
