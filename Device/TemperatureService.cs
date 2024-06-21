using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    public class TemperatureService
    {
        private ITemperatureRepository temperatureRepository;

        public TemperatureService(ITemperatureRepository temperatureRepository)
        {
            this.temperatureRepository = temperatureRepository;
        }
        public List<Temperature> GetAllDisease()
        {
            return temperatureRepository.GetAll();
        }

        public List<Temperature> GetAllDiseaseByName(string name)
        {
            return temperatureRepository.GetAllByUser(name);
        }

        public Temperature GetDiseaseById(long id)
        {
            return temperatureRepository.GetById(id);
        }
    }
}
