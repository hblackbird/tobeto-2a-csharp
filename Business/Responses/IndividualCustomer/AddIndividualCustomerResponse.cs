namespace Business.Responses.IndividualCustomer;

public class AddIndividualCustomerResponse
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
    public DateTime CreatedAt { get; set; }

    public AddIndividualCustomerResponse()
    {
    }

    public AddIndividualCustomerResponse(int customerId, string firstName, string lastName, string nationalIdentity, DateTime createdAt)
    {
        CustomerId = customerId;
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
        CreatedAt = createdAt;
    }
}