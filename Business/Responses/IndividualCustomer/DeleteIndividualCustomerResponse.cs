namespace Business.Responses.IndividualCustomer;

public class DeleteIndividualCustomerResponse
{
    public int Id { get; set; }
    public DateTime DeletedAt { get; set; }

    public DeleteIndividualCustomerResponse()
    {
    }

    public DeleteIndividualCustomerResponse(int ıd, DateTime deletedAt)
    {
        Id = ıd;
        DeletedAt = deletedAt;
    }
}