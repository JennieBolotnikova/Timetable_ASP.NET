using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimetableApp.Business.DTO
{
    public class ClassroomDTO
    {
        public int ClassroomID { get; set; }
        public int ClassroomNumber { get; set; }
        public int BuildingID { get; set; }
        public int NumberOfSeats { get; set; }
        public int ClassroomTypeID { get; set; }

        public BuildingDTO Building { get; set; }
        public ClassroomTypeDTO ClassroomType { get; set; }

    }
}
