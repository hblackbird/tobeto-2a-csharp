namespace Business
{
    public class AddCustomerResponse
    {
        public DateTime CreatedDate { get; set; }
        public AddCustomerResponse() { }
        public AddCustomerResponse(DateTime createdDate)
        {
            CreatedDate = createdDate;
        }
    }
}