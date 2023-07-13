using MockApi.Domain.Enums;

namespace MockApi.Domain.Models
{
    public class Car
    {
        public int Id { get; }
        public string Brand { get; }
        public string Model { get; }
        public Color Color { get; }

        public Car(int id, string brand, string model, Color color)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Color = color;
        }
    }
}
