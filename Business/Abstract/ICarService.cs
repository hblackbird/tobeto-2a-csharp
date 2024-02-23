using Business.Requests.Car;
using Business.Responses.Car;

namespace Business.Abstract;

public interface ICarService
{
    public AddCarResponse Add(AddCarRequest request);
    public DeleteCarResponse Delete(DeleteCarRequest request);
    public UpdateCarResponse Update(int id, UpdateCarRequest request);

    public GetCarResponse GetList(GetCarRequest request);
}
