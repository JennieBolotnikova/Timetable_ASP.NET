using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimetableApp.Web.Models
{
    public class BellViewModel
    {
        [Display(Name = "ID")]
        public int BellID { get; set; }
        [Display(Name = "Начало пары")]
        public TimeSpan LessonStartTime { get; set; }

        [Display(Name = "Конец пары")]
        public TimeSpan LessonEndTime { get; set; }
    }
}
