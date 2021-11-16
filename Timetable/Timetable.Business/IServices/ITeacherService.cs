using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface ITeacherService
    {
        TeacherDTO GetTeacherById(int id);
        IReadOnlyCollection<TeacherDTO> GetAllTeacheres();
        public void CreateTeacher(TeacherDTO item);
        public void UpdateTeacher(TeacherDTO item);
        public void ValidateTeacher(TeacherDTO item);
        public void DeleteTeacher(int id);
    }
}
