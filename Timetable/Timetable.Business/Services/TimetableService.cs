using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.IServices;
using TimetableApp.DataAccess.Entities;
using TimetableApp.DataAccess;

namespace TimetableApp.Business.Services
{
    public class TimetableService : ITimetableService
    {
        private TimetableContext db;
        private IEnumerable<Timetable> SearchByTeacherSemesterAndYear(int teacherID, int semesterID, DateTime year)
        {
            return db.Timetables.ToList()
                .Where(x => x.TeacherID == teacherID && x.SemesterID == semesterID && x.Date.Year == year.Year);
        }

        private IEnumerable<Timetable> SearchByFacultyAndSemester(int groupID, int semesterID)
        {
            return db.Timetables.ToList()
                .Where(x => x.GroupID == groupID && x.SemesterID == semesterID);
        }
    }
}
