namespace Business
{
    public class UpdateCustomerResponse
    {
        public int Id { get; set; }
        public DateTime UpdatedAt { get; set; }

        public UpdateCustomerResponse() { }
        public UpdateCustomerResponse(int id, DateTime updatedAt)
        {
            Id = id;
            UpdatedAt = updatedAt;
        }
    }
}