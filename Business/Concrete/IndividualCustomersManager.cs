using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.IndividualCustomer;
using Business.Responses.CorporateCustomer;
using Business.Responses.IndividualCustomer;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    internal class IndividualCustomersManager : IIndividualCustomerService
    {
        private readonly IndividualCustomerBusinessRules _individualCustomerRules;
        private readonly IIndividualCustomerDal _individualCustomerDal;
        private readonly IMapper _mapper;

        public IndividualCustomersManager(IndividualCustomerBusinessRules individualCustomerRules, IIndividualCustomerDal individualCustomerDal, IMapper mapper)
        {
            _individualCustomerRules = individualCustomerRules;
            _individualCustomerDal = individualCustomerDal;
            _mapper = mapper;
        }

        public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request)
        {
            IndividualCustomer IndividualCustomerToAdd = _mapper.Map<IndividualCustomer>(request);
            _individualCustomerDal.Add(IndividualCustomerToAdd);
            AddIndividualCustomerResponse response = _mapper.Map<AddIndividualCustomerResponse>(IndividualCustomerToAdd);
            return response;
        }

        public DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request)
        {
            IndividualCustomer user = _individualCustomerRules.FindId(request.Id);
            _individualCustomerRules.CheckIfCorporateCustomerNoExists(request.Id);
            _individualCustomerDal.Delete(user);
            DeleteIndividualCustomerResponse userResponse = _mapper.Map<DeleteIndividualCustomerResponse>(user);
            return userResponse;
        }

        public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request)
        {
            IList<IndividualCustomer> individualCustomerList = _individualCustomerDal.GetList();
            var response = _mapper.Map<GetIndividualCustomerListResponse>(individualCustomerList);
            return response;
        }

        public UpdateIndividualCustomerResponse Update(int id, UpdateIndividualCustomerRequest request)
        {
            IndividualCustomer existingUser = _individualCustomerDal.Get(m => m.Id == id);

            if (existingUser == null)
            {
                throw new Exception("Customer not found");
            }

            _mapper.Map(request, existingUser);
            _individualCustomerDal.Update(existingUser);

            UpdateIndividualCustomerResponse response = _mapper.Map<UpdateIndividualCustomerResponse>(existingUser);
            return response;
        }
    }
}
