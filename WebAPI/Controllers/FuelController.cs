using Business;
using Business.Abstract;
using Business.Requests.Fuel;
using Business.Responses.Fuel;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FuelController : ControllerBase
{
    private readonly IFuelService _fuelService; // Field

    public FuelController(IFuelService fuelService)
    {
        _fuelService = fuelService;
    }


    [HttpGet] // GET 
    public GetFuelListResponse GetList([FromQuery] GetFuelListRequest request)
    {
        GetFuelListResponse response = _fuelService.GetList(request);
        return response; // JSON
    }

    [HttpPost] // POST http://localhost:5245/api/brands
    public ActionResult<AddFuelResponse> Add(AddFuelRequest request)
    {
        AddFuelResponse response = _fuelService.Add(request);

        return CreatedAtAction(nameof(GetList), response); // 201 Created
    }
    [HttpDelete]
    public DeleteFuelResponse Delete(DeleteFuelRequest request)
    {
        DeleteFuelResponse fuelResponse = _fuelService.Delete(request);
        return fuelResponse;
    }
    [HttpPut("{id}")]
    public ActionResult<UpdateFuelResponse> UpdateFuel(int id, [FromBody] UpdateFuelRequest request)
    {
        try
        {
            UpdateFuelResponse response = _fuelService.Update(id, request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
