namespace Business.Dtos.IndividualCustomer;

public class IndividualCustomerListItemDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }

    public IndividualCustomerListItemDto()
    {
    }

    public IndividualCustomerListItemDto(int ıd, string firstName, string lastName, string nationalIdentity)
    {
        Id = ıd;
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
    }
}