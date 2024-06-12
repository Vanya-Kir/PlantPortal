using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant
{
    public class PlantService
    {
        private IPlantRepository plantRepository;

        public PlantService(IPlantRepository plantRepository)
        {
            this.plantRepository = plantRepository;
        }
        public List<Plant> GetAllPlant()
        {
            return plantRepository.GetAll();
        }

        public List<Plant> GetAllPlantByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<Plant>();
            }

            return plantRepository.GetAllByName(name);
        }

        public Plant GetPlantById(long id)
        {
            return plantRepository.GetById(id);
        }
    }
}
