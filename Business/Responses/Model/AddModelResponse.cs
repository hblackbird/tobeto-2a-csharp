namespace Business.Responses.Model;

public class AddModelResponse
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string Name { get; set; }
    public short Year { get; set; }
    public decimal DailyPrice { get; set; }
    public DateTime CreatedAt { get; set; }

    public AddModelResponse() { }
    public AddModelResponse(int ıd, int brandId, int fuelId, int transmissionId, string name, short year, decimal dailyPrice, DateTime createdAt)
    {
        Id = ıd;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        Year = year;
        DailyPrice = dailyPrice;
        CreatedAt = createdAt;
    }

}
