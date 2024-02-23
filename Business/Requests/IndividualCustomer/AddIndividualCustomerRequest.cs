using Entities.Concrete;

namespace Business.Requests.IndividualCustomer;

public class AddIndividualCustomerRequest
{
    public int CustomerId {  get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }

    public AddIndividualCustomerRequest()
    {
    }

    public AddIndividualCustomerRequest(int customerId, string firstName, string lastName, string nationalIdentity)
    {
        CustomerId = customerId;
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
    }
}