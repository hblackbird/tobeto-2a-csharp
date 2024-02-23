namespace Business.Requests.CorporateCustomer;

public class DeleteCorporateCustomerRequest
{
    public int Id { get; set; }

    public DeleteCorporateCustomerRequest(){}

    public DeleteCorporateCustomerRequest(int id)
    {
        Id = id;
    }
}