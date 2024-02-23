
using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules;

public class CustomerBusinessRules
{
    private readonly ICustomersDal _customerDal;

    public CustomerBusinessRules(ICustomersDal customerDal)
    {
        _customerDal = customerDal;
    }

    public void CheckIfUserNoExists(int id)
    {
        bool isExists = _customerDal.GetList().Any(a => a.Id == id);
        if (!isExists)
        {
            throw new BusinessException("This id not found");
        }
    }
    public Customers FindId(int id)
    {
        Customers customer = _customerDal.GetList().Where(a => a.Id == id).FirstOrDefault();
        return customer;
    }
}
