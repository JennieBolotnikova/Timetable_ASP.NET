using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimetableApp.Business.DTO
{
    public class GroupDTO
    {

        public int GroupID { get; set; }

        public string GroupName { get; set; }
        public int GroupNumber { get; set; }
        public int FacultyID { get; set; }
        public int NumberOfStudents { get; set; }

    }
}
