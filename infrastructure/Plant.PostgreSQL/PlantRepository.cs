namespace Plant.PostgreSQL
{
    public class PlantRepository : IPlantRepository
    {
        public List<Plant> GetAll()
        {
            return new List<Plant>() { new Plant { Id = 1, Name = "test_all", Description = "test description" } };
        }

        public List<Plant> GetAllByName(string name)
        {
            return new List<Plant>() { new Plant{ Id = 1, Name = "test", Description = "test description"} };
        }

        public Plant GetById(long id)
        {
            return new Plant { Id = 1, Name = "test by id", Description = "test description" };
        }
    }
}
