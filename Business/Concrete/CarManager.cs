using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Car;
using Business.Responses.Car;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CarManager : ICarService
{
    private readonly ICarDal _carDal;
    private readonly CarBusinessRules _carBusinessRules;
    private readonly IMapper _mapper;

    public CarManager(ICarDal carDal, CarBusinessRules carBusinessRules, IMapper mapper)
    {
        _carDal = carDal;
        _carBusinessRules = carBusinessRules;
        _mapper = mapper;
    }

    public AddCarResponse Add(AddCarRequest request)
    {
        _carBusinessRules.CheckIfCarPlateNotExists(request.Plate);

        Car carToAdd = _mapper.Map<Car>(request);
        _carDal.Add(carToAdd);
        AddCarResponse response = _mapper.Map<AddCarResponse>(carToAdd);
        return response;
    }

    public GetCarResponse GetList(GetCarRequest request)
    {
        IList<Car> carList = _carDal.GetList();

        GetCarResponse response = _mapper.Map<GetCarResponse>(carList); // Mapping
        return response;
    }
    public DeleteCarResponse Delete(DeleteCarRequest request)
    {
        Car car = _carBusinessRules.FindId(request.Id);
        _carBusinessRules.CheckIfCarNoExists(request.Id);
        _carDal.Delete(car);
        DeleteCarResponse carResponse = _mapper.Map<DeleteCarResponse>(car);
        return carResponse;
    }

    public UpdateCarResponse Update(int id, UpdateCarRequest request)
    {
        Car existingCar = _carDal.Get(c => c.Id == id);

        if (existingCar == null)
        {
            throw new Exception("Car not found");
        }

        _mapper.Map(request, existingCar);
        _carDal.Update(existingCar);

        UpdateCarResponse response = _mapper.Map<UpdateCarResponse>(existingCar);
        return response;
    }

}
