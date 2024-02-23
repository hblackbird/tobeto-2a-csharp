using Business.Responses.Users;
using Business.Requests.Users;
using Core.Utilities.Security.JWT;

namespace Business.Abstract;

public interface IUserService
{
    public AddUserResponse Add(AddUserRequest request);
    public DeleteUserResponse Delete(DeleteUserRequest request);
    public UpdateUserResponse Update(int id, UpdateUserRequest request);
    AccessToken Login(LoginRequest request);
    public GetUserListResponse GetList(GetUserListRequest request);
}
