using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;
namespace Business.BusinessRules;

public class FuelBusinessRules
{
    private readonly IFuelDal _fueldal;

    public FuelBusinessRules(IFuelDal fueldal) {
        _fueldal = fueldal;
    }
    public void CheckIfFuelNameNotExists (string fuelName)
    {
        bool isExists = _fueldal.GetList().Any(f => f.Name == fuelName);
        if (isExists)
        {
            throw new Exception("Fuel already exists.");
        }
    }
    public Fuel FindId(int id)
    {
        Fuel fuel = _fueldal.GetList().Where(a => a.Id == id).FirstOrDefault();
        return fuel;
    }
    public void CheckIfFuelNoExists(int id)
    {
        bool isExists = _fueldal.GetList().Any(a => a.Id == id);
        if (!isExists)
        {
            throw new Exception("This id not found");
        }
    }
}
