using Core.Entities;

namespace Entities.Concrete;

public class Model : Entity<int>
{
    public int FuelId { get; set; }
    public int BrandId { get; set; }
    public int TransmissionId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public short ModelYear { get; set; }

    public Brand? Brand { get; set; } = null;
    public Fuel? Fuel { get; set; } = null;
    public Transmission? Transmission { get; set; } = null;
    //public ICollection<Car>? Cars { get; set; } = null;
    public Model() { }

    public Model(int fuelId, int brandId, int transmissionId, string name, decimal dailyPrice, Brand? brand, Fuel? fuel, Transmission? transmission, short modelYear)
    {
        FuelId = fuelId;
        BrandId = brandId;
        TransmissionId = transmissionId;
        Name = name;
        DailyPrice = dailyPrice;
        Brand = brand;
        Fuel = fuel;
        Transmission = transmission;
        ModelYear = modelYear;
    }

}
