using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface IClassroomTypeService
    {
        ClassroomTypeDTO GetClassroomTypeById(int id);
        IReadOnlyCollection<ClassroomTypeDTO> GetAllClassroomTypes();
        public void CreateClassroomType(ClassroomTypeDTO item);
        public void UpdateClassroomType(ClassroomTypeDTO item);
        public void ValidateClassroomType(ClassroomTypeDTO item);
        public void DeleteClassroomType(int id);
    }
}
