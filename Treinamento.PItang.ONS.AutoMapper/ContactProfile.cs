using AutoMapper;
using Pitang.Treinamento.ONS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Treinamento.Pitang.ONS.Views;

namespace Treinamento.PItang.ONS.AutoMapper
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ContactDto>()
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name)).ReverseMap();
            CreateMap<Contact, ContactDto>()
                .ForMember(dest => dest.Number, opts => opts.MapFrom(src => src.Number)).ReverseMap();
            CreateMap<Contact, ContactDto>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id)).ReverseMap();
            CreateMap<Contact, ContactDto>()
                .ForMember(dest => dest.IsDeleted, opts => opts.MapFrom(src => src.IsDeleted)).ReverseMap();
        }
    }
}
