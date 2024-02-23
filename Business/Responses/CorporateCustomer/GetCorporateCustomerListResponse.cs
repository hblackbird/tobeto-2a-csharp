using Business.Dtos.CorporateCustomer;

namespace Business.Responses.CorporateCustomer;

public class GetCorporateCustomerListResponse
{

    public ICollection<CorporateCustomerListItemDto> Items { get; set; }

    public GetCorporateCustomerListResponse()
    {
        Items = Array.Empty<CorporateCustomerListItemDto>();
    }

    public GetCorporateCustomerListResponse(ICollection<CorporateCustomerListItemDto> items)
    {
        Items = items;
    }
}