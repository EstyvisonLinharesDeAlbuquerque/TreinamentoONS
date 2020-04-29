using AutoMapper;
using Pitang.Treinamento.ONS.Entities;
using Treinamento.Pitang.ONS.Views;

namespace Treinamento.PItang.ONS.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id)).ReverseMap();
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.IsDeleted, opts => opts.MapFrom(src => src.IsDeleted)).ReverseMap();
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.FirstName, opts => opts.MapFrom(src => src.FirstName)).ReverseMap();
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.LastName, opts => opts.MapFrom(src => src.LastName)).ReverseMap();
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.UserName, opts => opts.MapFrom(src => src.UserName)).ReverseMap();
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Password, opts => opts.MapFrom(src => src.Password)).ReverseMap();
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.ContactDtos, opts => opts.MapFrom(src => src.ContactsUser)).ReverseMap();
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.MessageDtos, opts => opts.MapFrom(src => src.MessagesUser)).ReverseMap();
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.StoryDtos, opts => opts.MapFrom(src => src.StoriesUser)).ReverseMap();

        }
    }
}
