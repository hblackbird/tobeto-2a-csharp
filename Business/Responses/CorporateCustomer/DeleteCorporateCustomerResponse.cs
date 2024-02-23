namespace Business.Responses.CorporateCustomer;

public class DeleteCorporateCustomerResponse
{
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public DateTime DeletedAt { get; set; }

    public DeleteCorporateCustomerResponse()
    {
    }

    public DeleteCorporateCustomerResponse(string companyName, string taxNo, DateTime deletedAt)
    {
        CompanyName = companyName;
        TaxNo = taxNo;
        DeletedAt = deletedAt;
    }
}