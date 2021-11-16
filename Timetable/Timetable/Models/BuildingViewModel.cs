using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class BuildingViewModel
    {
        [Display(Name = "ID")]
        public int BuildingID { get; set; }

        [Display(Name = "Название корпуса")]
        public string BuildingName { get; set; }
    }
}
