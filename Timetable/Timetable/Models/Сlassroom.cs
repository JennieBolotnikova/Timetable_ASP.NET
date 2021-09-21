using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.Models
{
    public class Сlassroom
    {
        public Сlassroom(int сlassroomID, int сlassroomNumber, int buildingID, int numberOfSeats, int сlassroomTypeID)
        {
            СlassroomID = сlassroomID;
            СlassroomNumber = сlassroomNumber;
            BuildingID = buildingID;
            NumberOfSeats = numberOfSeats;
            СlassroomTypeID = сlassroomTypeID;
        }

        public int СlassroomID { get; set; }
        public int СlassroomNumber { get; set; }
        public int BuildingID { get; set; }
        public int NumberOfSeats { get; set; }
        public int СlassroomTypeID { get; set; }

    }
}
