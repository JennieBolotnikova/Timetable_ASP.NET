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
    public class TimetableService : ITimetableService
    {
        private readonly IRepository<Timetable> _timetableRepository;

        private readonly IMapper _mapper;
        public TimetableService(IRepository<Timetable> timetableRepository, IMapper mapper)
        {
            _timetableRepository = timetableRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<TimetableDTO> GetAllTimetables()
        {
            return _mapper.Map<IEnumerable<TimetableDTO>>(_timetableRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public TimetableDTO GetTimetableById(int id)
        {
            if (id == null)
                throw new ValidationException("", "");
            var response = _timetableRepository.Get(id);
            if (response == null)
                throw new ValidationException("", "");
            return _mapper.Map<TimetableDTO>(response);
        }
        public void CreateTimetable(TimetableDTO item)
        {
            ValidateTimetable(item);

            _timetableRepository.Create(_mapper.Map<Timetable>(item));
        }
        public void UpdateTimetable(TimetableDTO item)
        {
            ValidateTimetable(item);

            _timetableRepository.Update(_mapper.Map<Timetable>(item));
        }
        public void ValidateTimetable(TimetableDTO item)
        {
            if (string.IsNullOrEmpty(item.ID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteTimetable(int id)
        {
            if (_timetableRepository.Get(id) is null)
                throw new Exception("");

            _timetableRepository.Delete(id);
        }
        public IReadOnlyCollection<TimetableDTO> TeachersTimetable(int teacherId)
        {
            return _mapper.Map <IEnumerable<TimetableDTO>>(_timetableRepository.GetAll()).Where(x => x.TeacherID == teacherId)
                .ToList().AsReadOnly();
        }

    }
}
