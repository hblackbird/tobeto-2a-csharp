namespace Business.Responses.Model;

public class UpdateModelResponse
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string Name { get; set; }
    public short Year { get; set; }
    public decimal DailyPrice { get; set; }
    public DateTime UpdatedAt { get; set; }

    public UpdateModelResponse(int id, int brandId, int fuelId, int transmissionId, string name, short year, decimal dailyPrice, DateTime updatedAt)
    {
        Id = id;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        Year = year;
        DailyPrice = dailyPrice;
        UpdatedAt = updatedAt;
    }


    public UpdateModelResponse() { }
}
