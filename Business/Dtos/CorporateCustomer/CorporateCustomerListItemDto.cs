namespace Business.Dtos.CorporateCustomer;

public class CorporateCustomerListItemDto
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }

    public CorporateCustomerListItemDto()
    {
    }

    public CorporateCustomerListItemDto(int ıd, string companyName, string taxNo)
    {
        Id = ıd;
        CompanyName = companyName;
        TaxNo = taxNo;
    }
}
