using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.IServices;
using TimetableApp.DataAccess.Interfaces;
using TimetableApp.DataAccess.Entities;
using TimetableApp.Business.DTO;
using TimetableApp.Business.Infrastructure;
using AutoMapper;

namespace TimetableApp.Business.Services
{
    public class DayService : IDayService
    {
        private readonly IRepository<Day> _dayRepository;

        private readonly IMapper _mapper;
        public DayService(IRepository<Day> dayRepository, IMapper mapper)
        {
            _dayRepository = dayRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<DayDTO> GetAllDays()
        {
            return _mapper.Map<IEnumerable<DayDTO>>(_dayRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public DayDTO GetDayById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _dayRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<DayDTO>(response);
        }
        public void CreateDay(DayDTO item)
        {
            ValidateDay(item);

            _dayRepository.Create(_mapper.Map<Day>(item));
        }
        public void UpdateDay(DayDTO item)
        {
            ValidateDay(item);

            _dayRepository.Update(_mapper.Map<Day>(item));
        }
        public void ValidateDay(DayDTO item)
        {
            if (string.IsNullOrEmpty(item.DayID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteDay(int id)
        {
            if (_dayRepository.Get(id) is null)
                throw new Exception("");

            _dayRepository.Delete(id);
        }
    }
}
