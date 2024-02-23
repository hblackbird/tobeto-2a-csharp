
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework;

public class EfCorporateCustomersDal : EfEntityRepositoryBase<CorporateCustomer, int, RentACarContext>, ICorporateCustomerDal
{
    public EfCorporateCustomersDal(RentACarContext context) : base(context)
    {
    }
}
