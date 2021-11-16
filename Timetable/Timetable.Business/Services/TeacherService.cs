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
    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Teacher> _teacherRepository;

        private readonly IMapper _mapper;
        public TeacherService(IRepository<Teacher> teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<TeacherDTO> GetAllTeacheres()
        {
            return _mapper.Map<IEnumerable<TeacherDTO>>(_teacherRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public TeacherDTO GetTeacherById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _teacherRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<TeacherDTO>(response);
        }
        public void CreateTeacher(TeacherDTO item)
        {
            ValidateTeacher(item);

            _teacherRepository.Create(_mapper.Map<Teacher>(item));
        }
        public void UpdateTeacher(TeacherDTO item)
        {
            ValidateTeacher(item);

            _teacherRepository.Update(_mapper.Map<Teacher>(item));
        }
        public void ValidateTeacher(TeacherDTO item)
        {
            if (string.IsNullOrEmpty(item.TeacherID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteTeacher(int id)
        {
            if (_teacherRepository.Get(id) is null)
                throw new Exception("");

            _teacherRepository.Delete(id);
        }
    }
}
