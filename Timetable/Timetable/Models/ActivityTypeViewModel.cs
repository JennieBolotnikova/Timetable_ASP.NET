using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class ActivityTypeViewModel
    {
        [Display(Name = "ID")]
        public int ActivityTypeID { get; set; }

        [Display(Name = "Тип занятия")]
        public string ActivityTypeName { get; set; }

        [Display(Name = "Сокр. название")]
        public string ActivityTypesShortName { get; set; }
    }
}
