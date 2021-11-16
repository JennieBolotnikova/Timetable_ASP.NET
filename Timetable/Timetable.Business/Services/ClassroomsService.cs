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
    public class ClassroomsService : IClassroomsService
    {
        private readonly IRepository<Classroom> _classroomRepository;

        private readonly IMapper _mapper;
        public ClassroomsService(IRepository<Classroom> classroomRepository, IMapper mapper)
        {
            _classroomRepository = classroomRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<ClassroomDTO> GetAllClassrooms()
        {
            return _mapper.Map<IEnumerable<ClassroomDTO>>(_classroomRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public ClassroomDTO GetClassroomById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _classroomRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<ClassroomDTO>(response);
        }
        public void CreateClassroom(ClassroomDTO item)
        {
            ValidateClassroom(item);

            _classroomRepository.Create(_mapper.Map<Classroom>(item));
        }
        public void UpdateClassroom(ClassroomDTO item)
        {
            ValidateClassroom(item);

            _classroomRepository.Update(_mapper.Map<Classroom>(item));
        }
        public void ValidateClassroom(ClassroomDTO item)
        {
            if (string.IsNullOrEmpty(item.ClassroomID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteClassroom(int id)
        {
            if (_classroomRepository.Get(id) is null)
                throw new Exception("");

            _classroomRepository.Delete(id);
        }
    }
}
