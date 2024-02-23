using Business.Requests.Fuel;
using Business.Responses.Fuel;

namespace Business.Abstract;

public interface IFuelService
{
    public AddFuelResponse Add(AddFuelRequest request);
    public DeleteFuelResponse Delete(DeleteFuelRequest request);
    public UpdateFuelResponse Update(int id, UpdateFuelRequest request);

    public GetFuelListResponse GetList(GetFuelListRequest request);
}
