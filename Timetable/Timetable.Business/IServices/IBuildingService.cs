using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface IBuildingService
    {
        BuildingDTO GetBuildingById(int id);
        IReadOnlyCollection<BuildingDTO> GetAllBuildings();
        public void CreateBuilding(BuildingDTO item);
        public void UpdateBuilding(BuildingDTO item);
        public void ValidateBuilding(BuildingDTO item);
        public void DeleteBuilding(int id);
    }
}
