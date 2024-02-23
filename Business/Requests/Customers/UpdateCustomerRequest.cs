namespace Business
{
    public class UpdateCustomerRequest
    {
        public int CustomerId { get; set; }

        public UpdateCustomerRequest() { }
        public UpdateCustomerRequest(int customerId)
        {
            CustomerId = customerId;
        }
    }
}