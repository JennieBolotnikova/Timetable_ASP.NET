using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.Models
{
    public class Group
    {
        public Group(int groupID, string groupName, int groupNumber, int facultyID, int numberOfStudents)
        {
            GroupID = groupID;
            GroupName = groupName;
            GroupNumber = groupNumber;
            FacultyID = facultyID;
            NumberOfStudents = numberOfStudents;
        }

        public int GroupID { get; set; }

        public string GroupName { get; set; }
        public int GroupNumber { get; set; }
        public int FacultyID { get; set; }
        public int NumberOfStudents { get; set; }

    }
}
