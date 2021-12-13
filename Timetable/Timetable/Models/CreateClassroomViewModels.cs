using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimetableApp.Web.Models
{
    public class CreateClassroomViewModels
    {
        public ClassroomViewModel ClassroomViewModel { get; set; }
        public List<BuildingViewModel> Buildings { get; set; }
        public List<ClassroomTypeViewModel> ClassroomTypes { get; set; }

        public IEnumerable<int> SelectedBuildingIds { get; set; }
        public IEnumerable<int> SelectedClassroomTypeIds { get; set; }
    }
}
