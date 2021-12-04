using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimetableApp.DataAccess.Entities
{
    public class Classroom
    {
        public int ClassroomID { get; set; }
        public int ClassroomNumber { get; set; }
        public int BuildingID { get; set; }
        public int NumberOfSeats { get; set; }
        public int ClassroomTypeID { get; set; }
        public Building Building { get; set; }
        public ClassroomType ClassroomType { get; set; }


    }
}
