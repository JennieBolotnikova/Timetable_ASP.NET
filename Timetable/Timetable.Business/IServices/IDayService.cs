using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface IDayService
    {
        DayDTO GetDayById(int id);
        IReadOnlyCollection<DayDTO> GetAllDays();
        public void CreateDay(DayDTO item);
        public void UpdateDay(DayDTO item);
        public void ValidateDay(DayDTO item);
        public void DeleteDay(int id);
    }
}
