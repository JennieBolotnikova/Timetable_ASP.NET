using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class ClassroomViewModel
    {
        [Display(Name = "Classroom")]
        public int ClassroomID { get; set; }
        public int ClassroomNumber { get; set; }

        [Display(Name = "Classroom")]
        public int BuildingID { get; set; }

        [Display(Name = "Number of seats")]
        public int NumberOfSeats { get; set; }
        [Display(Name = "Classroom Type")]
        public int ClassroomTypeID { get; set; }
    }
}
