namespace Device.Data
{
    public class TemeratureDto
    {
        public string? User { get; set; }

        public double Degrees { get; set; }

        public Temperature Convert()
        {
            return new Temperature { User = this.User, Degrees = this.Degrees, Date = DateTime.Now};
        }
    }
}
