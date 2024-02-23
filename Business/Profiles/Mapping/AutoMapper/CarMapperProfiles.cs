using AutoMapper;
using Business.Dtos.Car;
using Business.Requests.Car;
using Business.Responses.Car;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper;

public class CarMapperProfiles : Profile
{
    public CarMapperProfiles()
    {
        CreateMap<AddCarRequest, Car>();
        CreateMap<Car, AddCarResponse>();

        CreateMap<Car, CarListItemDto>();
        CreateMap<IList<Car>, GetCarResponse>()
            .ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
        CreateMap<Car, DeleteCarResponse>();
        CreateMap<UpdateCarRequest, Car>();
        CreateMap<Car, UpdateCarResponse>()
           .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
    }
}