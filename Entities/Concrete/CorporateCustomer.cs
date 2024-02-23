using Core.Entities;

namespace Entities.Concrete;

public class CorporateCustomer : Entity<int>
{
    public int CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public Customers Customer { get; set; }

    public CorporateCustomer() { }

    public CorporateCustomer(string companyName, string taxNo, Customers? customer, int id)
    {
        CompanyName = companyName;
        TaxNo = taxNo;
        Customer = customer;
        CustomerId = id;
    }
}
