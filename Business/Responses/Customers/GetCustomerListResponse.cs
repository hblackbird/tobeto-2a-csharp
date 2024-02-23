using Business.Dtos.Customer;

namespace Business
{
    public class GetCustomerListResponse
    {
        public ICollection<CustomerListItemDto> Items { get; set; }

        public GetCustomerListResponse()
        {
            Items = Array.Empty<CustomerListItemDto>();
        }

        public GetCustomerListResponse(ICollection<CustomerListItemDto> items)
        {
            Items = items;
        }
    }
}