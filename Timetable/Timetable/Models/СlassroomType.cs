using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.Models
{
    public class СlassroomType
    {
        public СlassroomType(int сlassroomTypeID, string сlassroomTypeName)
        {
            СlassroomTypeID = сlassroomTypeID;
            СlassroomTypeName = сlassroomTypeName;
        }

        public int СlassroomTypeID { get; set; }
        public string СlassroomTypeName { get; set; }

    }
}
