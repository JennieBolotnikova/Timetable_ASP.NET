using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimetableApp.DataAccess.Entities
{
    public class Day
    {

        public int DayID { get; set; }
        public string DayName { get; set; }
        public string DayShortName { get; set; }
    }
}
