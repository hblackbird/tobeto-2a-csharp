using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    internal class CorporateCustomerManager : ICorporateCustomerService
    {

        private readonly CorporateCustomerBusinessRules _corporateCustomerRules;
        private readonly ICorporateCustomerDal _corporateCustomerDal;
        private readonly IMapper _mapper;

        public CorporateCustomerManager(CorporateCustomerBusinessRules corporateCustomerRules, ICorporateCustomerDal corporateCustomerDal, IMapper mapper)
        {
            _corporateCustomerRules = corporateCustomerRules;
            _corporateCustomerDal = corporateCustomerDal;
            _mapper = mapper;
        }

        public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request)
        {
            CorporateCustomer corporateCustomerToAdd = _mapper.Map<CorporateCustomer>(request);
            _corporateCustomerDal.Add(corporateCustomerToAdd);
            AddCorporateCustomerResponse response = _mapper.Map<AddCorporateCustomerResponse>(corporateCustomerToAdd);
            return response;
        }

        public DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request)
        {
            CorporateCustomer user = _corporateCustomerRules.FindId(request.Id);
            _corporateCustomerRules.CheckIfCorporateCustomerNoExists(request.Id);
            _corporateCustomerDal.Delete(user);
            DeleteCorporateCustomerResponse userResponse = _mapper.Map<DeleteCorporateCustomerResponse>(user);
            return userResponse;
        }

        public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request)
        {
            IList<CorporateCustomer> corporateCustomerList = _corporateCustomerDal.GetList();
            var response = _mapper.Map<GetCorporateCustomerListResponse>(corporateCustomerList);
            return response;
        }

        public UpdateCorporateCustomerResponse Update(int id, UpdateCorporateCustomerRequest request)
        {
            CorporateCustomer existingUser = _corporateCustomerDal.Get(m => m.Id == id);

            if (existingUser == null)
            {
                throw new Exception("Customer not found");
            }

            _mapper.Map(request, existingUser);
            _corporateCustomerDal.Update(existingUser);

            UpdateCorporateCustomerResponse response = _mapper.Map<UpdateCorporateCustomerResponse>(existingUser);
            return response;
        }
    }
}
