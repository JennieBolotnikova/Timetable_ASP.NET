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
    public class SemesterService : ISemesterService
    {
        private readonly IRepository<Semester> _semesterRepository;

        private readonly IMapper _mapper;
        public SemesterService(IRepository<Semester> semesterRepository, IMapper mapper)
        {
            _semesterRepository = semesterRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<SemesterDTO> GetAllSemesters()
        {
            return _mapper.Map<IEnumerable<SemesterDTO>>(_semesterRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public SemesterDTO GetSemesterById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _semesterRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<SemesterDTO>(response);
        }
        public void CreateSemester(SemesterDTO item)
        {
            ValidateSemester(item);

            _semesterRepository.Create(_mapper.Map<Semester>(item));
        }
        public void UpdateSemester(SemesterDTO item)
        {
            ValidateSemester(item);

            _semesterRepository.Update(_mapper.Map<Semester>(item));
        }
        public void ValidateSemester(SemesterDTO item)
        {
            if (string.IsNullOrEmpty(item.SemesterID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteSemester(int id)
        {
            if (_semesterRepository.Get(id) is null)
                throw new Exception("");

            _semesterRepository.Delete(id);
        }
    }
}
