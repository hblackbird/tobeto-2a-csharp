using Business.Abstract;
using Business.Requests.Users;
using Business.Responses.Users;
using Core.Utilities.Security.JWT;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet] // GET 
    public GetUserListResponse GetList([FromQuery] GetUserListRequest request)
    {
        GetUserListResponse response = _userService.GetList(request);
        return response; // JSON
    }

    [HttpPost] // POST
    public ActionResult<AddUserResponse> Add(AddUserRequest request)
    {
        AddUserResponse response = _userService.Add(request);

        return CreatedAtAction(nameof(GetList), response); // 201 Created
    }
    [HttpPost("Login")]
    public AccessToken Login([FromBody] LoginRequest request)
    {
        return _userService.Login(request);
    }

    [HttpDelete]
    public DeleteUserResponse Delete(DeleteUserRequest request)
    {
        DeleteUserResponse userResponse = _userService.Delete(request);
        return userResponse;
    }

    [HttpPut("{id}")]
    public ActionResult<UpdateUserResponse> UpdateUser(int id, [FromBody] UpdateUserRequest request)
    {
        try
        {
            UpdateUserResponse response = _userService.Update(id, request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
