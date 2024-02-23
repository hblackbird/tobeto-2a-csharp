using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;
namespace Business.BusinessRules;

public class TransmissionBusinessRules
{
    private readonly ITransmissionDal _Transmissiondal;

    public TransmissionBusinessRules(ITransmissionDal Transmissiondal) {
        _Transmissiondal = Transmissiondal;
    }
    public void CheckIfTransmissionNameNotExists (string TransmissionName)
    {
        bool isExists = _Transmissiondal.GetList().Any(t => t.Name == TransmissionName);
        if (isExists)
        {
            throw new Exception("Transmission already exists.");
        }
    }

    public Transmission FindId(int id)
    {
        Transmission transmission = _Transmissiondal.GetList().Where(a => a.Id == id).FirstOrDefault();
        return transmission;
    }
    public void CheckIfTransmissionNoExists(int id)
    {
        bool isExists = _Transmissiondal.GetList().Any(a => a.Id == id);
        if (!isExists)
        {
            throw new Exception("This id not found");
        }
    }
}
