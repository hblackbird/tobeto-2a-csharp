using Business;
using Business.Abstract;
using Business.Requests.Car;
using Business.Responses.Car;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly ICarService _carService; // Field

    public CarController(ICarService carService)
    {
        _carService = carService;
    }


    [HttpGet] 
    public GetCarResponse GetList([FromQuery] GetCarRequest request) 
    {
        GetCarResponse response = _carService.GetList(request);
        return response; // JSON
    }

    [HttpPost] 
    public ActionResult<AddCarResponse> Add(AddCarRequest request)
    {
        AddCarResponse response = _carService.Add(request);

        return CreatedAtAction(nameof(GetList), response); // 201 Created
    }


    [HttpDelete]
    public DeleteCarResponse Delete(DeleteCarRequest request)
    {
        DeleteCarResponse carResponse = _carService.Delete(request);
        return carResponse;
    }


    [HttpPut("{id}")]
    public ActionResult<UpdateCarResponse> UpdateCar(int id, [FromBody] UpdateCarRequest request)
    {
        try
        {
            UpdateCarResponse response = _carService.Update(id, request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
