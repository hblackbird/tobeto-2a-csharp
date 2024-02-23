using Business.Dtos.Users;

namespace Business.Responses.Users;
    public class GetUserListResponse
    {
    public ICollection<UsersListItemDto> Items { get; set; }

    public GetUserListResponse()
    {
        Items = Array.Empty<UsersListItemDto>();
    }

    public GetUserListResponse(ICollection<UsersListItemDto> items)
    {
        Items = items;
    }

}
