using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface IFacultyService
    {
        FacultyDTO GetFacultyById(int id);
        IReadOnlyCollection<FacultyDTO> GetAllFaculties();
        public void CreateFaculty(FacultyDTO item);
        public void UpdateFaculty(FacultyDTO item);
        public void ValidateFaculty(FacultyDTO item);
        public void DeleteFaculty(int id);
    }
}
