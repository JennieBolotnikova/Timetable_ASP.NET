using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.Models
{
    public class Bell
    {

        public int BellID { get; set; }
        public DateTime LessonStartTime { get; set; }
        public DateTime LessonEndTime { get; set; }
    }
}
