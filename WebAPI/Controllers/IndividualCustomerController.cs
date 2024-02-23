using Business.Abstract;
using Business.Requests.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IndividualCustomerController : ControllerBase
{
    private readonly IIndividualCustomerService _individualCustomerService;

    public IndividualCustomerController(IIndividualCustomerService individualCustomerService)
    {
        _individualCustomerService = individualCustomerService;
    }

    [HttpGet]
    public GetIndividualCustomerListResponse GetList([FromQuery] GetIndividualCustomerListRequest request )
    {
        GetIndividualCustomerListResponse reponse = _individualCustomerService.GetList( request );
        return reponse;
    }

    [HttpPost]
    public ActionResult<AddIndividualCustomerResponse> Add(AddIndividualCustomerRequest request)
    {
        AddIndividualCustomerResponse response = _individualCustomerService.Add( request );
        return CreatedAtAction(nameof(GetList), response);
    }
    [HttpDelete]
    public DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request)
    {
        DeleteIndividualCustomerResponse response = _individualCustomerService.Delete( request );
        return response;
    }

    [HttpPut("{id}")]
    public ActionResult<UpdateIndividualCustomerResponse> Update(int id,[FromBody]UpdateIndividualCustomerRequest request)
    {
        try
        {
            UpdateIndividualCustomerResponse response = _individualCustomerService.Update(id, request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
