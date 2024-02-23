using Business;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ICustomersService _customersService;

    public CustomerController(ICustomersService customersService)
    {
        _customersService = customersService;
    }

    [HttpGet] // GET 
    public GetCustomerListResponse GetList([FromQuery] GetCustomerListRequest request)
    {
        GetCustomerListResponse response = _customersService.GetList(request);
        return response; // JSON
    }

    [HttpPost] // POST
    public ActionResult<AddCustomerResponse> Add(AddCustomerRequest request)
    {
        AddCustomerResponse response = _customersService.Add(request);

        return CreatedAtAction(nameof(GetList), response); // 201 Created
    }

    [HttpDelete]
    public DeleteCustomerResponse Delete(DeleteCustomerRequest request)
    {
        DeleteCustomerResponse customerResponse = _customersService.Delete(request);
        return customerResponse;
    }

}
