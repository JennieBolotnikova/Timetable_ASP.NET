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
            CreateMap<Classroom, ClassroomDTO>().ReverseMap();
        }
        

    }
}
