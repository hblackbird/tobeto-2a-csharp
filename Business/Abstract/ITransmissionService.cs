using Business.Requests.Transmission;
using Business.Responses.Transmission;
using Entities.Concrete;

namespace Business.Abstract;

public interface ITransmissionService
{
    public AddTransmissionResponse Add(AddTransmissionRequest request);
    public DeleteTransmissionResponse Delete(DeleteTransmissionRequest request);
    public UpdateTransmissionResponse Update(int id, UpdateTransmissionRequest request);

    public GetTransmissionListResponse GetList(GetTransmissionListRequest request);
}
