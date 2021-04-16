using AutoMapper;
using Sample.DtoModels;
using Sample.Entitys;

namespace Sample.Profiles
{
    public class ClassProfile : Profile
    {
        public ClassProfile()
        {
            CreateMap<Class, ClassDto>()
                .ForMember(dest => dest.ClassId,opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Name))
                ;

            CreateMap<AddOrUpdateClassDto, Class>();
        }
    }
}
