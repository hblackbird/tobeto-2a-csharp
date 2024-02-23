using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;

namespace Business.Abstract;

public interface ICorporateCustomerService
{
    public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request);
    public DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request);
    public UpdateCorporateCustomerResponse Update(int id, UpdateCorporateCustomerRequest request);

    public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request);
}
