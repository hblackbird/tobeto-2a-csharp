
namespace Business.Abstract;

public interface ICustomersService
{
    public AddCustomerResponse Add(AddCustomerRequest request);
    public DeleteCustomerResponse Delete(DeleteCustomerRequest request);
    public UpdateCustomerResponse Update(int id, UpdateCustomerRequest request);

    public GetCustomerListResponse GetList(GetCustomerListRequest request);
}
