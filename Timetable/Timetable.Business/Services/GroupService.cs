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
    public class GroupService : IGroupService
    {
        private readonly IRepository<Group> _groupRepository;

        private readonly IMapper _mapper;
        public GroupService(IRepository<Group> groupRepository, IMapper mapper)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<GroupDTO> GetAllGroups()
        {
            return _mapper.Map<IEnumerable<GroupDTO>>(_groupRepository.GetAll())
                .ToList().AsReadOnly();
        }

        public GroupDTO GetGroupById(int id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var response = _groupRepository.Get(id);
            if (response == null)
                throw new ValidationException("Телефон не найден", "");
            return _mapper.Map<GroupDTO>(response);
        }
        public void CreateGroup(GroupDTO item)
        {
            ValidateGroup(item);

            _groupRepository.Create(_mapper.Map<Group>(item));
        }
        public void UpdateGroup(GroupDTO item)
        {
            ValidateGroup(item);

            _groupRepository.Update(_mapper.Map<Group>(item));
        }
        public void ValidateGroup(GroupDTO item)
        {
            if (string.IsNullOrEmpty(item.GroupID.ToString()))
                throw new ValidationException("");
        }

        public void DeleteGroup(int id)
        {
            if (_groupRepository.Get(id) is null)
                throw new Exception("");

            _groupRepository.Delete(id);
        }
    }
}
