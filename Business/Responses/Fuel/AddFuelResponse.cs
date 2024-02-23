namespace Business.Responses.Fuel
{
    public class AddFuelResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public AddFuelResponse()
        {

        }
        public AddFuelResponse(int id, string name, DateTime createdDate)
        {
            Id = id;
            Name = name;
            CreatedDate = createdDate;
        }
    }
}