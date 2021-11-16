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
    public class FacultyService : IFacultyService
    {
        private readonly IRepository<Faculty> _facultyRepository;

        private readonly IMapper _mapper;
        public FacultyService(IRepository<Faculty> facultyRepository, IMapper mapper)
        {
            _facultyRepository = facultyRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<FacultyDTO> GetAllFaculties()
        {
            return _mapper.Map<IEnumerable<FacultyDTO>>(_facultyRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public FacultyDTO GetFacultyById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _facultyRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<FacultyDTO>(response);
        }
        public void CreateFaculty(FacultyDTO item)
        {
            ValidateFaculty(item);

            _facultyRepository.Create(_mapper.Map<Faculty>(item));
        }
        public void UpdateFaculty(FacultyDTO item)
        {
            ValidateFaculty(item);

            _facultyRepository.Update(_mapper.Map<Faculty>(item));
        }
        public void ValidateFaculty(FacultyDTO item)
        {
            if (string.IsNullOrEmpty(item.FacultyID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteFaculty(int id)
        {
            if (_facultyRepository.Get(id) is null)
                throw new Exception("");

            _facultyRepository.Delete(id);
        }
    }
}
