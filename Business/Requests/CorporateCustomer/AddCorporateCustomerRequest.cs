using Entities.Concrete;

namespace Business.Requests.CorporateCustomer;

public class AddCorporateCustomerRequest
{
    public int CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }

    public AddCorporateCustomerRequest(){}
    public AddCorporateCustomerRequest(int customerId, string companyName, string taxNo)
    {
        CustomerId = customerId;
        CompanyName = companyName;
        TaxNo = taxNo;
    }
}