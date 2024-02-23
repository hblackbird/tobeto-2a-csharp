using Business;
using Business.Abstract;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransmissionController : ControllerBase
{
    private readonly ITransmissionService _transmissionService; // Field

    public TransmissionController(ITransmissionService transmissionService)
    {
        _transmissionService = transmissionService;
    }


    [HttpGet] // GET http://localhost:5245/api/brands
    public GetTransmissionListResponse GetList([FromQuery] GetTransmissionListRequest request)
    {
        GetTransmissionListResponse response = _transmissionService.GetList(request);
        return response; // JSON
    }

    [HttpPost] // POST http://localhost:5245/api/brands
    public ActionResult<AddTransmissionResponse> Add(AddTransmissionRequest request)
    {
        AddTransmissionResponse response = _transmissionService.Add(request);

        return CreatedAtAction(nameof(GetList), response); // 201 Created
    }
    [HttpDelete]
    public DeleteTransmissionResponse Delete(DeleteTransmissionRequest request)
    {
        DeleteTransmissionResponse transmissionResponse = _transmissionService.Delete(request);
        return transmissionResponse;
    }
    [HttpPut("{id}")]
    public ActionResult<UpdateTransmissionResponse> UpdateBrand(int id, [FromBody] UpdateTransmissionRequest request)
    {
        try
        {
            UpdateTransmissionResponse response = _transmissionService.Update(id, request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
