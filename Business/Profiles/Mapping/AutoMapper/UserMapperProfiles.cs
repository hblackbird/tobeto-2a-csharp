using AutoMapper;
using Business.Dtos.Users;
using Business.Requests.Users;
using Business.Responses.Users;
using Core.Entities;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper;

public class UserMapperProfiles : Profile
{
    public UserMapperProfiles()
    {
        CreateMap<AddUserRequest, User>();
        CreateMap<User, AddUserResponse>();

        CreateMap<User, UsersListItemDto>();
        CreateMap<IList<User>, GetUserListResponse>()
            .ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
        CreateMap<User, DeleteUserResponse>();
        CreateMap<UpdateUserRequest, User>();
        CreateMap<User, UpdateUserResponse>()
           .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
    }
}
