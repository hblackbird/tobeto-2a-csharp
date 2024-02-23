using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Fuel;
using Business.Responses.Fuel;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class FuelManager : IFuelService
{
    private readonly IFuelDal _fuelDal;
    private readonly FuelBusinessRules _fuelBusinessRules;
    private readonly IMapper _mapper;

    public FuelManager(IFuelDal fuelDal, FuelBusinessRules fuelBusinessRules, IMapper mapper)
    {
        _fuelDal = fuelDal; 
        _fuelBusinessRules = fuelBusinessRules;
        _mapper = mapper;
    }

    public AddFuelResponse Add(AddFuelRequest request)
    {
        _fuelBusinessRules.CheckIfFuelNameNotExists(request.Name);
        
        Fuel fuelToAdd = _mapper.Map<Fuel>(request);
        _fuelDal.Add(fuelToAdd);

        AddFuelResponse response = _mapper.Map<AddFuelResponse>(fuelToAdd);
        return response;
    }

    public GetFuelListResponse GetList(GetFuelListRequest request)
    {

        IList<Fuel> fuelList = _fuelDal.GetList();
        GetFuelListResponse response = _mapper.Map<GetFuelListResponse>(fuelList);
        return response;
    }

    public DeleteFuelResponse Delete(DeleteFuelRequest request)
    {
        Fuel fuel = _fuelBusinessRules.FindId(request.Id);
        _fuelBusinessRules.CheckIfFuelNoExists(request.Id);
        _fuelDal.Delete(fuel);
        DeleteFuelResponse fuelResponse = _mapper.Map<DeleteFuelResponse>(fuel);
        return fuelResponse;
    }

    public UpdateFuelResponse Update(int id, UpdateFuelRequest request)
    {
        Fuel existingFuel = _fuelDal.Get(f => f.Id == id);

        if (existingFuel == null)
        {
            throw new Exception("Fuel not found");
        }

        _mapper.Map(request, existingFuel);
        _fuelDal.Update(existingFuel);

        UpdateFuelResponse response = _mapper.Map<UpdateFuelResponse>(existingFuel);
        return response;
    }

}
