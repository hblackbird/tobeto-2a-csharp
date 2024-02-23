namespace Business
{
    public class DeleteCustomerResponse
    {
        public int Id { get; set; }
        public DateTime DeletedAt { get; set; }

        public DeleteCustomerResponse() { }

        public DeleteCustomerResponse(int id, DateTime deletedAt)
        {
            Id = id;
            DeletedAt = deletedAt;
        }
    }
}