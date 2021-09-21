using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.Models
{
    public class Day
    {
        public Day(int dayID, string dayName, string dayShortName)
        {
            DayID = dayID;
            DayName = dayName;
            DayShortName = dayShortName;
        }

        public int DayID { get; set; }
        public string DayName { get; set; }
        public string DayShortName { get; set; }
    }
}
