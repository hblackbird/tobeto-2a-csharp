namespace Business.Requests.CorporateCustomer;

public class UpdateCorporateCustomerRequest
{
    public int CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }

    public UpdateCorporateCustomerRequest(){}

    public UpdateCorporateCustomerRequest(int customerId, string companyName, string taxNo)
    {
        CustomerId = customerId;
        CompanyName = companyName;
        TaxNo = taxNo;
    }
}