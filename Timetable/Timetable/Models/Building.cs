using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.Models
{
    public class Building
    {
        public int BuildingID { get; set; }
        public string BuildingName { get; set; }

        public Building(int buildingID, string buildingName)
        {
            BuildingID = buildingID;
            BuildingName = buildingName;
        }
    }
}
