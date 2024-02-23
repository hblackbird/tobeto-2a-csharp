namespace Business.Responses.CorporateCustomer;

public class UpdateCorporateCustomerResponse
{
    public int CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public DateTime UpdatedAt { get; set; }

    public UpdateCorporateCustomerResponse()
    {
    }

    public UpdateCorporateCustomerResponse(int customerId, string companyName, string taxNo, DateTime updatedAt)
    {
        CustomerId = customerId;
        CompanyName = companyName;
        TaxNo = taxNo;
        UpdatedAt = updatedAt;
    }
}