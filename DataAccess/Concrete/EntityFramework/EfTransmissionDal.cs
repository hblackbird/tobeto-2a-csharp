using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EfTransmissionDal : EfEntityRepositoryBase<Transmission, int, RentACarContext>, ITransmissionDal
{
    public EfTransmissionDal(RentACarContext context) : base(context)
    {
    }
}