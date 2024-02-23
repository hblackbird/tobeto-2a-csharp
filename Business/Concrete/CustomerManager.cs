using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Responses.Users;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CustomerManager : ICustomersService
{
    private readonly CustomerBusinessRules _customerRules;
    private readonly ICustomersDal _customerDal;
    private readonly IMapper _mapper;

    public CustomerManager(CustomerBusinessRules customerRules, ICustomersDal customerDal, IMapper mapper)
    {
        _customerRules = customerRules;
        _customerDal = customerDal;
        _mapper = mapper;
    }

    public AddCustomerResponse Add(AddCustomerRequest request)
    {
        Customers customerToAdd = _mapper.Map<Customers>(request);
        _customerDal.Add(customerToAdd);
        AddCustomerResponse response = _mapper.Map<AddCustomerResponse>(customerToAdd);
        return response;
    }

    public DeleteCustomerResponse Delete(DeleteCustomerRequest request)
    {
        Customers customer = _customerRules.FindId(request.CustomerId);
        _customerRules.CheckIfUserNoExists(request.CustomerId);
        _customerDal.Delete(customer);
        DeleteCustomerResponse customerResponse = _mapper.Map<DeleteCustomerResponse>(customer);
        return customerResponse;

    }
    public GetCustomerListResponse GetList(GetCustomerListRequest request)
    {
        IList<Customers> customerList = _customerDal.GetList();
        var response = _mapper.Map<GetCustomerListResponse>(customerList);
        return response;
    }

    public UpdateCustomerResponse Update(int id, UpdateCustomerRequest request)
    {
        throw new NotImplementedException();
    }
}
