using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Users;
using Business.Responses.Users;
using Core.Entities;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class UserManager : IUserService
{
    private readonly UsersRules _userRules;
    private readonly IUsersDal _userDal;
    private readonly IMapper _mapper;
    private readonly ITokenHelper _tokenHelper;

    public UserManager(UsersRules userRules, IMapper mapper, IUsersDal usersDal,ITokenHelper tokenhelper)
    {
        _userRules = userRules;
        _mapper = mapper;
        _userDal = usersDal;
        _tokenHelper = tokenhelper;
    }
    public AddUserResponse Add(AddUserRequest request)
    {
        User userToAdd = _mapper.Map<User>(request);
        byte[] passwordSalt, passwordHash;
        HashingHelper.CreatePasswordHash(request.Password,out passwordHash, out passwordSalt);
        userToAdd.PasswordSalt = passwordSalt;
        userToAdd.PasswordHash = passwordHash;
        userToAdd.Approved = false;
        _userDal.Add(userToAdd);
        AddUserResponse response = _mapper.Map<AddUserResponse>(userToAdd);
        return response;
    }

    public UpdateUserResponse Update(int id, UpdateUserRequest request)
    {
         User existingUser = _userDal.Get(m => m.Id == id);

        if (existingUser == null)
        {
            throw new Exception("User not found");
        }

        _mapper.Map(request, existingUser);
        _userDal.Update(existingUser);

        UpdateUserResponse response = _mapper.Map<UpdateUserResponse>(existingUser);
        return response;
    }


    public DeleteUserResponse Delete(DeleteUserRequest request)
    {
         User user = _userRules.FindId(request.Id);
        _userRules.CheckIfUserNoExists(request.Id);
        _userDal.Delete(user);
        DeleteUserResponse userResponse = _mapper.Map<DeleteUserResponse>(user);
        return userResponse;
    }

    public GetUserListResponse GetList(GetUserListRequest request)
    {
        IList<User> userList = _userDal.GetList();
        var response = _mapper.Map<GetUserListResponse>(userList);
        return response;
    }

    public AccessToken Login(LoginRequest request)
    {
        User? user = _userDal.Get(i=> i.Email == request.Email);
        int role = (int)user.RoleId;
        bool isPasswordCorrect = HashingHelper.VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt);
        if (!isPasswordCorrect)
            throw new Exception("Sifre Yanlis");
        return _tokenHelper.CreateToken(user,role);
    }
}
