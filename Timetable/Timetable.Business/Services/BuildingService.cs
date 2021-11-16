using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.IServices;
using TimetableApp.DataAccess.Interfaces;
using TimetableApp.DataAccess.Repositories;
using TimetableApp.DataAccess.Entities;
using TimetableApp.Business.DTO;
using TimetableApp.Business.Infrastructure;
using TimetableApp.DataAccess;
using AutoMapper;

namespace TimetableApp.Business.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IRepository<Building> _buildingRepository;

        private readonly IMapper _mapper;
        public BuildingService(IRepository<Building> buildingRepository, IMapper mapper)
        {
            _buildingRepository = buildingRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<BuildingDTO> GetAllBuildings()
        {
            return _mapper.Map<IEnumerable<BuildingDTO>>(_buildingRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public BuildingDTO GetBuildingById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _buildingRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<BuildingDTO>(response);
        }
        public void CreateBuilding(BuildingDTO item)
        {
            ValidateBuilding(item);

            _buildingRepository.Create(_mapper.Map<Building>(item));
        }
        public void UpdateBuilding(BuildingDTO item)
        {
            ValidateBuilding(item);

            _buildingRepository.Update(_mapper.Map<Building>(item));
        }
        public void ValidateBuilding(BuildingDTO item)
        {
            if (string.IsNullOrEmpty(item.BuildingID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteBuilding(int id)
        {
            if (_buildingRepository.Get(id) is null)
                throw new Exception("");

            _buildingRepository.Delete(id);
        }
    }
}
