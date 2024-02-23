using Azure.Core;
using Business.Abstract;
using Business.Dtos.Model;
using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;
namespace Business.BusinessRules;

public class ModelBusinessRules
{
    private readonly IModelDal _modelDal;
    private readonly IBrandService _brandService;

    public ModelBusinessRules(IModelDal modelDal,IBrandService brandService)
    {
        _modelDal = modelDal;
        _brandService = brandService;
    }

    public void CheckIfModelNameIsValid(string Name)
    {
        if (Name.Length < 2)
        {
            throw new BusinessException("Model name must be at least 2 characters long.");
        }
    }
    public  void CheckIfDailyPriceIsValid(decimal dailyPrice)
    {
        if (dailyPrice <= 0)
        {
            throw new BusinessException("Daily price must be greater than 0.");
        }
    }

    public Model FindId(int id)
    {
        Model model = _modelDal.GetList().Where(a => a.Id == id).FirstOrDefault();
        return model;
    }
    public void CheckIfModelNoExists(int id)
    {
        bool isExists = _modelDal.GetList().Any(a => a.Id == id);
        if (!isExists)
        {
            throw new BusinessException("This id not found");
        }
    }
    public void CheckIfBrandNameExists(int brandId)
    {
        Brand? brand = _brandService.GetById(brandId);
        if (brand is null)
            throw new Exception("Marka bulunamadı");
    }
}
