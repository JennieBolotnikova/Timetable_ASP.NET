using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface IActivityTypeService
    {
        ActivityTypeDTO GetActivityTypeById(int id);
        IReadOnlyCollection<ActivityTypeDTO> GetAllActivityTypes();
        public void CreateActivityType(ActivityTypeDTO item);
        public void UpdateActivityType(ActivityTypeDTO item);
        public void ValidateActivityType(ActivityTypeDTO item);
        public void DeleteActivityType(int id);
    }
}
