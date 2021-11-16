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
    public class ActivityTypeService : IActivityTypeService
    {
        private readonly IRepository<ActivityType> _activityTypeRepository;

        private readonly IMapper _mapper;

        public ActivityTypeService(IRepository<ActivityType> activityTypeRepository, IMapper mapper)
        {
            _activityTypeRepository = activityTypeRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<ActivityTypeDTO> GetAllActivityTypes()
        {
            return _mapper.Map<IEnumerable<ActivityTypeDTO>>(_activityTypeRepository.GetAll())
                .ToList().AsReadOnly();
        }
        public ActivityTypeDTO GetActivityTypeById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _activityTypeRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<ActivityTypeDTO>(response);
        }

        public void CreateActivityType(ActivityTypeDTO item)
        {
            ValidateActivityType(item);

            _activityTypeRepository.Create(_mapper.Map<ActivityType>(item));
        }
        public void UpdateActivityType(ActivityTypeDTO item)
        {
            ValidateActivityType(item);

            _activityTypeRepository.Update(_mapper.Map<ActivityType>(item));
        }

        public void ValidateActivityType(ActivityTypeDTO item)
        {
            if (string.IsNullOrEmpty(item.ActivityTypeID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteActivityType(int id)
        {
            if (_activityTypeRepository.Get(id) is null)
                throw new Exception("");

            _activityTypeRepository.Delete(id);
        }
    }
}
