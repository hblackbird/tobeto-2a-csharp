namespace Business.Requests.Model;

public class UpdateModelRequest
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string Name { get; set; }
    public short Year { get; set; }
    public decimal DailyPrice { get; set; }
    
    public UpdateModelRequest() { }
    public UpdateModelRequest(int ıd, int brandId, int fuelId, int transmissionId, string name, short year, decimal dailyPrice)
    {
        Id = ıd;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        Year = year;
        DailyPrice = dailyPrice;
    }

}
