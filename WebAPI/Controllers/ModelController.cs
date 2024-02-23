using AutoMapper;
using Business.Abstract;
using Business.Requests.Model;
using Business.Responses.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IModelService _modelService;
        private readonly IMapper _mapper;

        public ModelsController(IModelService modelService, IMapper mapper)
        {
            _modelService = modelService ?? throw new ArgumentNullException(nameof(modelService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


        [HttpGet] 
        public GetModelListResponse GetList([FromQuery] GetModelListRequest request)
        {
            GetModelListResponse response = _modelService.GetList(request);
            return response; // JSON
        }

        [HttpPost] 
        public ActionResult<AddModelResponse> Add(AddModelRequest request)
        {
            AddModelResponse response = _modelService.Add(request);

            return CreatedAtAction(nameof(GetList), response); 
        }

        [HttpDelete] // DELETE http://localhost:5245/api/models/{id}
        public ActionResult<DeleteModelResponse> Delete(DeleteModelRequest request)
        {
            try
            {
                DeleteModelResponse response = _modelService.Delete(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<UpdateModelResponse> UpdateModel(int id, [FromBody] UpdateModelRequest request)
        {
            try
            {
                UpdateModelResponse response = _modelService.Update(id, request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}