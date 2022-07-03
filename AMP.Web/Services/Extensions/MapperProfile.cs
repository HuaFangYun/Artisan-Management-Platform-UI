﻿namespace AMP.Web.Services.Extensions;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<ArtisanCommand, ArtisanDto>().ReverseMap();
        CreateMap<ArtisanPageDto, ArtisanDto>().ReverseMap();
        CreateMap<UserCommand, UserDto>().ReverseMap();
        CreateMap<UserPageDto, UserDto>().ReverseMap();
        CreateMap<OrderPageDto, OrderDto>().ReverseMap()
            .ForMember(a => a.Address,
                x => x.MapFrom(a => a.WorkAddress));
        CreateMap<CustomerPageDto, CustomerDto>().ReverseMap();
        CreateMap<CustomerCommand, CustomerDto>().ReverseMap();
        CreateMap<ServicePageDto, ServiceDto>().ReverseMap();
        CreateMap<SchedulePageDto, ScheduleDto>().ReverseMap();
        CreateMap<ProposalPageDto, ProposalDto>().ReverseMap();
    }
}