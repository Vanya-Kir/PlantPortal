namespace Device.PostgreSQL
{
    public class TemperatureRepository : ITemperatureRepository
    {
        public List<Temperature> GetAll()
        {
            return new List<Temperature> { new Temperature { Date = DateTime.Now, Degrees = 22, Id = 1, User = "11" } };
        }

        public List<Temperature> GetAllByUser(string user)
        {
            return new List<Temperature> { 
                new Temperature { Date = new DateTime(2024, 6, 20, 9, 9, 32), Degrees = 19, Id = 1, User = "11" }, 
                new Temperature { Date = new DateTime(2024, 6, 20, 10, 10, 1), Degrees = 19, Id = 1, User = "11" }, 
                new Temperature { Date = new DateTime(2024, 6, 20, 11, 11, 23), Degrees = 20, Id = 1, User = "11" }, 
                new Temperature { Date = new DateTime(2024, 6, 20, 12, 11, 15), Degrees = 20, Id = 1, User = "11" }, 
                new Temperature { Date = new DateTime(2024, 6, 20, 13, 12, 47), Degrees = 20, Id = 1, User = "11" }, 
                new Temperature { Date = new DateTime(2024, 6, 20, 14, 12, 33), Degrees = 20, Id = 1, User = "11" }, 
                new Temperature { Date = new DateTime(2024, 6, 20, 15, 12, 52), Degrees = 21, Id = 1, User = "11" }, 
                new Temperature { Date = new DateTime(2024, 6, 20, 16, 13, 48), Degrees = 21, Id = 1, User = "11" }, 
                new Temperature { Date = new DateTime(2024, 6, 20, 17, 13, 30), Degrees = 21, Id = 1, User = "11" }, 
                new Temperature { Date = new DateTime(2024, 6, 20, 18, 13, 2), Degrees = 21, Id = 1, User = "11" }, 
                new Temperature { Date = new DateTime(2024, 6, 20, 19, 13, 57), Degrees = 22, Id = 1, User = "11" }, 
            };
        }

        public Temperature GetById(long id)
        {
            return new Temperature { Date = DateTime.Now, Degrees = 22, Id = 1, User = "11" };
        }
    }
}
