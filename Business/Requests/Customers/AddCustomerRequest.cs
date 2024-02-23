namespace Business
{
    public class AddCustomerRequest
    {
        public int UserId { get; set; }
        
        public AddCustomerRequest() { }
        public AddCustomerRequest(int id, int usertId)
        {
            UserId = usertId;
        }
    }
}