using Business;
using Business.Abstract;
using Business.Requests.Brand;
using Business.Responses.Brand;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly IBrandService _brandService; // Field

    public BrandsController(IBrandService brandService)
    {
        _brandService = brandService;
    }


    [HttpGet] // GET http://localhost:5245/api/brands
    public GetBrandListResponse GetList([FromQuery] GetBrandListRequest request) // Referans tipleri varsayılan olarak request body'den alır.
    {
        GetBrandListResponse response = _brandService.GetList(request);
        return response; // JSON
    }

    [HttpPost] // POST http://localhost:5245/api/brands
    //[Authorize] // Controller içerisinde kullanılır.
    public ActionResult<AddBrandResponse> Add(AddBrandRequest request)
    {
        // Log kodları
        try
        {
            AddBrandResponse response = _brandService.Add(request);

            //return response; // 200 OK
            return CreatedAtAction(nameof(GetList), response); // 201 Created
        }
        catch (Core.CrossCuttingConcerns.Exceptions.BusinessException exception)
        {
            return BadRequest(
                new Core.CrossCuttingConcerns.Exceptions.BusinessProblemDetails()
                {
                    Title = "Business Exception",
                    Status = StatusCodes.Status400BadRequest,
                    Detail = exception.Message,
                    Instance = HttpContext.Request.Path
                }
            );
            // 400 Bad Request
        }
    }


    [HttpDelete]
    public ActionResult<DeleteBrandResponse> Delete(DeleteBrandRequest request)
    {
        DeleteBrandResponse brandResponse = _brandService.Delete(request);
        return brandResponse;
    }

    [HttpPut("{id}")]
    public ActionResult<UpdateBrandResponse> UpdateBrand(int id, [FromBody] UpdateBrandRequest request)
    {
        try
        {
            UpdateBrandResponse response = _brandService.Update(id, request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
