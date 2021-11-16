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
    public class BellService : IBellService
    {
        private readonly IRepository<Bell> _bellRepository;

        private readonly IMapper _mapper;
        public BellService(IRepository<Bell> bellRepository, IMapper mapper)
        {
            _bellRepository = bellRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<BellDTO> GetAllBells()
        {
            return _mapper.Map<IEnumerable<BellDTO>>(_bellRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public BellDTO GetBellById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _bellRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<BellDTO>(response);
        }
        public void CreateBell(BellDTO item)
        {
            ValidateBell(item);

            _bellRepository.Create(_mapper.Map<Bell>(item));
        }
        public void UpdateBell(BellDTO item)
        {
            ValidateBell(item);

            _bellRepository.Update(_mapper.Map<Bell>(item));
        }
        public void ValidateBell(BellDTO item)
        {
            if (string.IsNullOrEmpty(item.BellID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteBell(int id)
        {
            if (_bellRepository.Get(id) is null)
                throw new Exception("");

            _bellRepository.Delete(id);
        }
    }
}
