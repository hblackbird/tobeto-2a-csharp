using Business.Requests.IndividualCustomer;
using Business.Responses.IndividualCustomer;

namespace Business.Abstract;

public interface IIndividualCustomerService
{
    public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request);
    public DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request);
    public UpdateIndividualCustomerResponse Update(int id, UpdateIndividualCustomerRequest request);

    public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request);

}
