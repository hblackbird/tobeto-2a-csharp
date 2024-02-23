using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;
namespace Business.BusinessRules;

public class BrandBusinessRules
{
    private readonly IBrandDal _brandDal;

    public BrandBusinessRules(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public void CheckIfBrandNameNotExists(string brandName)
    {
        bool isExists = _brandDal.Get(brand => brand.Name == brandName) is not null;
        if (isExists)
        {
            throw new BusinessException("Brand already exists.");
        }
    }

    public Brand FindId(int id)
    {
        Brand brand = _brandDal.GetList().Where(a=>a.Id == id).FirstOrDefault();
        return brand;
    }
    public void CheckIfBrandNoExists(int id)
    {
        bool isExists = _brandDal.GetList().Any(a => a.Id == id);
        if (!isExists)
        {
            throw new BusinessException("This id not found");
        }
    }
}
