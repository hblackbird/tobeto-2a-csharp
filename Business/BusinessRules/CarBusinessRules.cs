

using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules;

public class CarBusinessRules
{
    private readonly ICarDal _carDal;

    public CarBusinessRules(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public void CheckIfCarPlateNotExists(string plateName)
    {
        bool isExists = _carDal.GetList().Any(c => c.Plate == plateName);
        if (isExists)
        {
            throw new BusinessException("Car already exists.");
        }
    }
    public Car FindId(int id)
    {
        Car car = _carDal.GetList().Where(a => a.Id == id).FirstOrDefault();
        return car;
    }
    public void CheckIfCarNoExists(int id)
    {
        bool isExists = _carDal.GetList().Any(a => a.Id == id);
        if (!isExists)
        {
            throw new BusinessException("This id not found");
        }
    }
    public void CheckCarYear(int year)
    {
        bool isNotValid = year < 2002;
        if (isNotValid)
        {
            throw new BusinessException("Model Year must upper2002.");
        }
    }
}
