using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.Models
{
    public class Discipline
    {
        public Discipline(int disciplineID, string disciplineNmae)
        {
            DisciplineID = disciplineID;
            DisciplineNmae = disciplineNmae;
        }

        public int DisciplineID { get; set; }
        public string DisciplineNmae { get; set; }
    }
}
