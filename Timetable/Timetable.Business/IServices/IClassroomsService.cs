using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;


namespace TimetableApp.Business.IServices
{
    public interface IClassroomsService
    {
        ClassroomDTO GetClassroomById(int id);
        IReadOnlyCollection<ClassroomDTO> GetAllClassrooms();
        public void CreateClassroom(ClassroomDTO item);
        public void UpdateClassroom(ClassroomDTO item);
        public void ValidateClassroom(ClassroomDTO item);
        public void DeleteClassroom(int id);


    }
}
