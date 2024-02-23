using Business.Requests.Model;
using Business.Responses.Model;

namespace Business.Abstract;

public interface IModelService
{
    public AddModelResponse Add(AddModelRequest request);
    public DeleteModelResponse Delete(DeleteModelRequest request);
    public UpdateModelResponse Update(int id, UpdateModelRequest request);

    public GetModelByIdResponse GetById(GetModelByIdRequest request);
    public GetModelListResponse GetList(GetModelListRequest request);

}
