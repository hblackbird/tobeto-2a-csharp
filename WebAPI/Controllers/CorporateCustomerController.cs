using Business.Abstract;
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CorporateCustomerController : ControllerBase
{
    private readonly ICorporateCustomerService _corporateCustomerService;

    public CorporateCustomerController(ICorporateCustomerService corporateCustomerService)
    {
        _corporateCustomerService = corporateCustomerService;
    }

    [HttpGet]
    public GetCorporateCustomerListResponse GetList([FromQuery] GetCorporateCustomerListRequest request)
    {
        GetCorporateCustomerListResponse reponse = _corporateCustomerService.GetList(request);
        return reponse;
    }

    [HttpPost]
    public ActionResult<AddCorporateCustomerResponse> Add(AddCorporateCustomerRequest request)
    {
        AddCorporateCustomerResponse response = _corporateCustomerService.Add(request);
        return CreatedAtAction(nameof(GetList), response);
    }
    [HttpDelete]
    public DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request)
    {
        DeleteCorporateCustomerResponse response = _corporateCustomerService.Delete(request);
        return response;
    }

    [HttpPut("{id}")]
    public ActionResult<UpdateCorporateCustomerResponse> Update(int id, [FromBody] UpdateCorporateCustomerRequest request)
    {
        try
        {
            UpdateCorporateCustomerResponse response = _corporateCustomerService.Update(id, request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
