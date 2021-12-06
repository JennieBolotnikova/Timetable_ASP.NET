using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface ITimetableService
    {
        TimetableDTO GetTimetableById(int id);
        IReadOnlyCollection<TimetableDTO> GetAllTimetables();
        public void CreateTimetable(TimetableDTO item);
        public void UpdateTimetable(TimetableDTO item);
        public void ValidateTimetable(TimetableDTO item);
        public void DeleteTimetable(int id);

        public IReadOnlyCollection<TimetableDTO> TeachersTimetable(int teacherId);
    }
}
