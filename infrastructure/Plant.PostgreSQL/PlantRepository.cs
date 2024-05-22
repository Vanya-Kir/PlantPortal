namespace Plant.PostgreSQL
{
    public class PlantRepository : IPlantRepository
    {
        public List<Plant> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Plant> GetAllByName(string name)
        {
            return new List<Plant>() { new Plant{ Id = 1, Name = "test", Description = "test description"} };
        }
    }
}
