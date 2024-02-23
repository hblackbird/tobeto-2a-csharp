using AutoMapper;
using Business.Dtos.Customer;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper;

public class CustomerMapperProfiles : Profile
{
    public CustomerMapperProfiles() {

        CreateMap<AddCustomerRequest, Customers>();
        CreateMap<Customers, AddCustomerResponse>();

        CreateMap<Customers, CustomerListItemDto>();
        CreateMap<IList<Customers>, GetCustomerListResponse>()
            .ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
        CreateMap<Customers, DeleteCustomerResponse>();
        CreateMap<UpdateCustomerRequest, Customers>();
        CreateMap<Customers, UpdateCustomerResponse>()
           .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
    }
}
