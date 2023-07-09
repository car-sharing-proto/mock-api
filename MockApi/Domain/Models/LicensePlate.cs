namespace MockApi.Domain.Models
{
    public class LicensePlate
    {
        public string Series { get; }
        public int Number { get; }
        public int Region { get; }

        public LicensePlate(string series, int number, int region)
        {
            Series = series;
            Number = number;
            Region = region;
        }
    }
}
