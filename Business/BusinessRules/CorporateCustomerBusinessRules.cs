using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules;

public class CorporateCustomerBusinessRules
{
    private readonly ICorporateCustomerDal _corporateCustomerDal;

    public CorporateCustomerBusinessRules(ICorporateCustomerDal customerDal)
    {
        _corporateCustomerDal = customerDal;
    }

    public void CheckIfCorporateCustomerNoExists(int id)
    {
        bool isExists = _corporateCustomerDal.GetList().Any(a => a.Id == id);
        if (!isExists)
        {
            throw new BusinessException("This id not found");
        }
    }

    public CorporateCustomer FindId(int id)
    {
        CorporateCustomer corporateCustomer = _corporateCustomerDal.GetList().Where(a => a.Id == id).FirstOrDefault();
        return corporateCustomer;
    }
}
