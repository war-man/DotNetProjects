using Sample.DtoModels;
using Sample.Entitys;
using AutoMapper;

namespace Sample.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Courses, CourseDto>()
                .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Name))
                ;
        }
    }
}
