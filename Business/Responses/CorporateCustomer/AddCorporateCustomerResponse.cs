namespace Business.Responses.CorporateCustomer;

public class AddCorporateCustomerResponse
{
    public int CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public DateTime CreatedAt { get; set; }

    public AddCorporateCustomerResponse()
    {
    }

    public AddCorporateCustomerResponse(int customerId, string companyName, string taxNo, DateTime createdAt)
    {
        CustomerId = customerId;
        CompanyName = companyName;
        TaxNo = taxNo;
        CreatedAt = createdAt;
    }
}