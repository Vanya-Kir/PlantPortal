namespace Device.PostgreSQL
{
    public class HumidityRepository : IHumidityRepository
    {
        public List<Humidity> GetAll()
        {
            return new List<Humidity> { new Humidity { Date = DateTime.Now, Percentage = 31, Id = 1, User = "12345" } };
        }

        public List<Humidity> GetAllByUser(string user)
        {
            return new List<Humidity> { new Humidity { Date = DateTime.Now, Percentage = 31, Id = 2, User = "12345" } };
        }

        public Humidity GetById(long id)
        {
            return new Humidity { Date = DateTime.Now, Percentage = 31, Id = 3, User = "12345" };
        }
    }
}
