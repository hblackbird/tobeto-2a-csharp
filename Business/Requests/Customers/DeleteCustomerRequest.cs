namespace Business
{
    public class DeleteCustomerRequest
    {
        public int CustomerId { get; set; }

        public DeleteCustomerRequest() { }
        public DeleteCustomerRequest(int customerId)
        {
            CustomerId = customerId;
        }
    }
}