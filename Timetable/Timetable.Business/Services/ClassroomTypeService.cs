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
    public class ClassroomTypeService : IClassroomTypeService
    {
        private readonly IRepository<ClassroomType> _classroomTypeRepository;

        private readonly IMapper _mapper;
        public ClassroomTypeService(IRepository<ClassroomType> classroomTypeRepository, IMapper mapper)
        {
            _classroomTypeRepository = classroomTypeRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<ClassroomTypeDTO> GetAllClassroomTypes()
        {
            return _mapper.Map<IEnumerable<ClassroomTypeDTO>>(_classroomTypeRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public ClassroomTypeDTO GetClassroomTypeById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _classroomTypeRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<ClassroomTypeDTO>(response);
        }
        public void CreateClassroomType(ClassroomTypeDTO item)
        {
            ValidateClassroomType(item);

            _classroomTypeRepository.Create(_mapper.Map<ClassroomType>(item));
        }
        public void UpdateClassroomType(ClassroomTypeDTO item)
        {
            ValidateClassroomType(item);

            _classroomTypeRepository.Update(_mapper.Map<ClassroomType>(item));
        }
        public void ValidateClassroomType(ClassroomTypeDTO item)
        {
            if (string.IsNullOrEmpty(item.ClassroomTypeID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteClassroomType(int id)
        {
            if (_classroomTypeRepository.Get(id) is null)
                throw new Exception("");

                _classroomTypeRepository.Delete(id);
        }
    }
}
