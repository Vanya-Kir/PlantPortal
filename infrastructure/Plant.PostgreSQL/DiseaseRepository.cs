using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant.PostgreSQL
{
    public class DiseaseRepository : IDiseaseRepository
    {
        public List<Disease> GetAll()
        {
            return new List<Disease>() { new Disease { Id = 1, Name = "test_all d", Description = "test d description" } };
        }

        public List<Disease> GetAllByName(string name)
        {
            return new List<Disease>() { new Disease { Id = 1, Name = "test d", Description = "test d description" } };
        }

        public Disease GetById(long id)
        {
            return new Disease { Id = 1, Name = "test d by id", Description = "test d description" };
        }
    }
}
