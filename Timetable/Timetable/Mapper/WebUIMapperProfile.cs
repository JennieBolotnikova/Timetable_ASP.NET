using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TimetableApp.Business.DTO;
using TimetableApp.Web.Models;

namespace TimetableApp.Web.Mapper
{
    public class WebUIMapperProfile : Profile
    {
        public WebUIMapperProfile()
        {
            CreateMap<ActivityTypeDTO, ActivityTypeViewModel>().ReverseMap();
            CreateMap<BellDTO, BellViewModel>().ReverseMap();
            CreateMap<BuildingDTO, BuildingViewModel>().ReverseMap();
            CreateMap<ClassroomDTO, ClassroomViewModel>().ReverseMap();
            CreateMap<ClassroomTypeDTO, ClassroomTypeViewModel>().ReverseMap();
            CreateMap<DayDTO, DayViewModel>().ReverseMap();
            CreateMap<DisciplineDTO, DisciplineViewModel>().ReverseMap();
            CreateMap<FacultyDTO, FacultyViewModel>().ReverseMap();
            CreateMap<GroupDTO, GroupViewModel>().ReverseMap();
            CreateMap<SemesterDTO, SemesterViewModel>().ReverseMap();
            CreateMap<TeacherDTO, TeacherViewModel>().ReverseMap();
            CreateMap<TimetableDTO, TimetableViewModel>().ReverseMap();

        }
    }
}
