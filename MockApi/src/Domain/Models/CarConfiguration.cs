namespace Core.Domain.Models
{
    public class CarConfiguration
    {
        public Car Car { get; }
        public LicensePlate LicensePlate { get; set; }
        public Location Location { get; set; }

        public CarConfiguration(Car car, 
            LicensePlate licensePlate, Location location) 
        {
            Car = car;
            LicensePlate = licensePlate;
            Location = location;
        }
    }
}
