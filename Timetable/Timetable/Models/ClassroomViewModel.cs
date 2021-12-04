using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TimetableApp.Web.Models
{
    public class ClassroomViewModel
    {

        [Display(Name = "ID")]
        public int ClassroomID { get; set; }

        [Display(Name = "Номер аудитории")]
        public int ClassroomNumber { get; set; }

        [Display(Name = "Корпус")]
        public string Building { get; set; }
        public int BuildingID { get; set; }

        [Display(Name = "Количество мест")]
        public int NumberOfSeats { get; set; }
        [Display(Name = "Тип аудитории")]
        public string ClassroomType { get; set; }
        public int ClassroomTypeID { get; set; }
    }
}
