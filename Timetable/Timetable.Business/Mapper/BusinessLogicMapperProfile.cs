using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TimetableApp.Business.DTO;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.Business.Mapper
{
    public class BusinessLogicMapperProfile : Profile
    {
        public BusinessLogicMapperProfile()
        {
            CreateMap<ActivityType, ActivityTypeDTO>().ReverseMap();
            CreateMap<Bell, BellDTO>().ReverseMap();
            CreateMap<Building, BuildingDTO>().ReverseMap();
            CreateMap<Classroom, ClassroomDTO>().ReverseMap();
            CreateMap<ClassroomType, ClassroomTypeDTO>().ReverseMap();
            CreateMap<Day, DayDTO>().ReverseMap();
            CreateMap<Discipline, DisciplineDTO>().ReverseMap();
            CreateMap<Faculty, FacultyDTO>().ReverseMap();
            CreateMap<Group, GroupDTO>().ReverseMap();
            CreateMap<Semester, SemesterDTO>().ReverseMap();
            CreateMap<Teacher, TeacherDTO>().ReverseMap();
            CreateMap<Timetable, TimetableDTO>().ReverseMap();
        }
        

    }
}
