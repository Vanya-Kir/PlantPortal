namespace Plant
{
    public interface IDiseaseRepository
    {
        List<Disease> GetAll();

        List<Disease> GetAllByName(string name);

        Disease GetById(long id);
    }
}