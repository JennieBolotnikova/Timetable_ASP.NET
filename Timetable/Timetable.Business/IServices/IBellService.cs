using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface IBellService
    {
        BellDTO GetBellById(int id);
        IReadOnlyCollection<BellDTO> GetAllBells();
        public void CreateBell(BellDTO item);
        public void UpdateBell(BellDTO item);
        public void ValidateBell(BellDTO item);
        public void DeleteBell(int id);
    }
}
