
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework;

public class EfIndividualCustomersDal : EfEntityRepositoryBase<IndividualCustomer, int, RentACarContext>, IIndividualCustomerDal
{
    public EfIndividualCustomersDal(RentACarContext context) : base(context)
    {
    }
}