using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.Business.DTO;

namespace TimetableApp.Business.IServices
{
    public interface IGroupService
    {
        GroupDTO GetGroupById(int id);
        IReadOnlyCollection<GroupDTO> GetAllGroups();
        public void CreateGroup(GroupDTO item);
        public void UpdateGroup(GroupDTO item);
        public void ValidateGroup(GroupDTO item);
        public void DeleteGroup(int id);
    }
}
