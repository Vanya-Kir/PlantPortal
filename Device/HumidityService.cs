using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    public class HumidityService
    {
        private IHumidityRepository humidityRepository;

        public HumidityService(IHumidityRepository humidityRepository)
        {
            this.humidityRepository = humidityRepository;
        }
        public List<Humidity> GetAllDisease()
        {
            return humidityRepository.GetAll();
        }

        public List<Humidity> GetAllDiseaseByName(string name)
        {
            return humidityRepository.GetAllByUser(name);
        }

        public Humidity GetDiseaseById(long id)
        {
            return humidityRepository.GetById(id);
        }
    }
}
