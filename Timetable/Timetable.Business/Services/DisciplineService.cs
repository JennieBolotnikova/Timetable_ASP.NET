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
    public class DisciplineService : IDisciplineService
    {
        private readonly IRepository<Discipline> _disciplineRepository;

        private readonly IMapper _mapper;
        public DisciplineService(IRepository<Discipline> disciplineRepository, IMapper mapper)
        {
            _disciplineRepository = disciplineRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<DisciplineDTO> GetAllDisciplines()
        {
            return _mapper.Map<IEnumerable<DisciplineDTO>>(_disciplineRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public DisciplineDTO GetDisciplineById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _disciplineRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<DisciplineDTO>(response);
        }
        public void CreateDiscipline(DisciplineDTO item)
        {
            ValidateDiscipline(item);

            _disciplineRepository.Create(_mapper.Map<Discipline>(item));
        }
        public void UpdateDiscipline(DisciplineDTO item)
        {
            ValidateDiscipline(item);

            _disciplineRepository.Update(_mapper.Map<Discipline>(item));
        }
        public void ValidateDiscipline(DisciplineDTO item)
        {
            if (string.IsNullOrEmpty(item.DisciplineID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteDiscipline(int id)
        {
            if (_disciplineRepository.Get(id) is null)
                throw new Exception("");

            _disciplineRepository.Delete(id);
        }
    }
}
