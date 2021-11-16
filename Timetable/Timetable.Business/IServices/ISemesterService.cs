using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface ISemesterService
    {
        SemesterDTO GetSemesterById(int id);
        IReadOnlyCollection<SemesterDTO> GetAllSemesters();
        public void CreateSemester(SemesterDTO item);
        public void UpdateSemester(SemesterDTO item);
        public void ValidateSemester(SemesterDTO item);
        public void DeleteSemester(int id);
    }
}
