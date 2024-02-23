using AutoMapper;
using Business.Dtos.IndividualCustomer;
using Business.Dtos.Users;
using Business.Requests.IndividualCustomer;
using Business.Requests.Users;
using Business.Responses.IndividualCustomer;
using Entities.Concrete;
namespace Business.Profiles.Mapping.AutoMapper;

public class IndividualCustomerMapperProfiles : Profile
{
    public IndividualCustomerMapperProfiles()
    {
        CreateMap<AddIndividualCustomerRequest, IndividualCustomer>();
        CreateMap<IndividualCustomer, AddIndividualCustomerResponse>();

        CreateMap<IndividualCustomer, IndividualCustomerListItemDto>();
        CreateMap<IList<IndividualCustomer>, GetIndividualCustomerListResponse>()
            .ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
        CreateMap<IndividualCustomer, DeleteIndividualCustomerResponse>();
        CreateMap<UpdateIndividualCustomerRequest, IndividualCustomer>();
        CreateMap<IndividualCustomer, UpdateIndividualCustomerResponse>()
           .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
    }
}
