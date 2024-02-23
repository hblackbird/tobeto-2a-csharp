namespace Business.Requests.IndividualCustomer;

public class UpdateIndividualCustomerRequest
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }

    public UpdateIndividualCustomerRequest()
    {
    }

    public UpdateIndividualCustomerRequest(int customerId, string firstName, string lastName, string nationalIdentity)
    {
        CustomerId = customerId;
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
    }
}