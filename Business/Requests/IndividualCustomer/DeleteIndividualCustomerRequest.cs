namespace Business.Requests.IndividualCustomer;

public class DeleteIndividualCustomerRequest
{
    public int Id { get; set; }

    public DeleteIndividualCustomerRequest()
    {
    }

    public DeleteIndividualCustomerRequest(int ıd)
    {
        Id = ıd;
    }
}