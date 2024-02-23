using Business.Dtos.IndividualCustomer;

namespace Business.Responses.IndividualCustomer;

public class GetIndividualCustomerListResponse
{
    public ICollection<IndividualCustomerListItemDto> Items { get; set; }

    public GetIndividualCustomerListResponse()
    {
        Items = Array.Empty<IndividualCustomerListItemDto>();
    }

    public GetIndividualCustomerListResponse(ICollection<IndividualCustomerListItemDto> items)
    {
        Items = items;
    }
}