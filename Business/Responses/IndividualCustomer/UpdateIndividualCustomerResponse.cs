namespace Business.Responses.IndividualCustomer;

public class UpdateIndividualCustomerResponse
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
    public DateTime UpdatedAt { get; set; }

    public UpdateIndividualCustomerResponse()
    {
    }

    public UpdateIndividualCustomerResponse(int customerId, string firstName, string lastName, string nationalIdentity, DateTime updatedAt)
    {
        CustomerId = customerId;
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
        UpdatedAt = updatedAt;
    }
}