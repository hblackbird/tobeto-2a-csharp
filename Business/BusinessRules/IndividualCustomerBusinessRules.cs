using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules;

public class IndividualCustomerBusinessRules
{
    private readonly IIndividualCustomerDal _individualCustomerDal;

    public IndividualCustomerBusinessRules(IIndividualCustomerDal individualCustomerDal)
    {
        _individualCustomerDal = individualCustomerDal;
    }

    public void CheckIfCorporateCustomerNoExists(int id)
    {
        bool isExists = _individualCustomerDal.GetList().Any(a => a.Id == id);
        if (!isExists)
        {
            throw new BusinessException("This id not found");
        }
    }

    public IndividualCustomer FindId(int id)
    {
        IndividualCustomer individualCustomer = _individualCustomerDal.GetList().Where(a => a.Id == id).FirstOrDefault();
        return individualCustomer;
    }
}
