namespace MockApi.Domain.Models
{
    public class Location
    {
        public double x; 
        public double y;
        public double angle;

        public Location(double x, double y, double angle)
        {
            this.angle = angle;
            this.x = x;
            this.y = y;
        }
    }
}
