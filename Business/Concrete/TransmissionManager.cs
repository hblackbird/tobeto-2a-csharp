using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class TransmissionManager : ITransmissionService
{
    private readonly ITransmissionDal _transmissionDal;
    private readonly TransmissionBusinessRules _transmissionBusinessRules;
    private readonly IMapper _mapper;

    public TransmissionManager(ITransmissionDal transmissionDal, TransmissionBusinessRules transmissionBusinessRules, IMapper mapper)
    {
        _transmissionDal = transmissionDal; 
        _transmissionBusinessRules = transmissionBusinessRules;
        _mapper = mapper;
    }

    public AddTransmissionResponse Add(AddTransmissionRequest request)
    {
        _transmissionBusinessRules.CheckIfTransmissionNameNotExists(request.Name);

        Transmission transmissionToAdd = _mapper.Map<Transmission>(request);
        _transmissionDal.Add(transmissionToAdd);


        AddTransmissionResponse response = _mapper.Map<AddTransmissionResponse>(transmissionToAdd);
        return response;
    }

    public GetTransmissionListResponse GetList(GetTransmissionListRequest request)
    {

        IList<Transmission> transmissionList = _transmissionDal.GetList();
        GetTransmissionListResponse response = _mapper.Map<GetTransmissionListResponse>(transmissionList);
        return response;
    }
    public DeleteTransmissionResponse Delete(DeleteTransmissionRequest request)
    {
        Transmission transmission = _transmissionBusinessRules.FindId(request.Id);
        _transmissionBusinessRules.CheckIfTransmissionNoExists(request.Id);
        _transmissionDal.Delete(transmission);
        DeleteTransmissionResponse transmissionResponse = _mapper.Map<DeleteTransmissionResponse>(transmission);
        return transmissionResponse;
    }

    public UpdateTransmissionResponse Update(int id, UpdateTransmissionRequest request)
    {
        Transmission existingTransmission = _transmissionDal.Get(t => t.Id == id);

        if (existingTransmission == null)
        {
            throw new Exception("Transmission not found");
        }

        _mapper.Map(request, existingTransmission);
        _transmissionDal.Update(existingTransmission);

        UpdateTransmissionResponse response = _mapper.Map<UpdateTransmissionResponse>(existingTransmission);
        return response;
    }

}
