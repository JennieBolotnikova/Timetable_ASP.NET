using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface IDisciplineService
    {
        DisciplineDTO GetDisciplineById(int id);
        IReadOnlyCollection<DisciplineDTO> GetAllDisciplines();
        public void CreateDiscipline(DisciplineDTO item);
        public void UpdateDiscipline(DisciplineDTO item);
        public void ValidateDiscipline(DisciplineDTO item);
        public void DeleteDiscipline(int id);
    }
}
