using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimetableApp.Web.Models
{
    public class CreateGroupViewModel
    {
        public GroupViewModel GroupViewModel { get; set; }
        public List<FacultyViewModel> Faculties { get; set; }
        public IEnumerable<int> SelectedFacultyIds { get; set; }
    }
}
