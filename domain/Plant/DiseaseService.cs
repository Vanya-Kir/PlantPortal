using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant
{
    public class DiseaseService
    {
        private IDiseaseRepository diseaseRepository;

        public DiseaseService(IDiseaseRepository diseaseRepository)
        {
            this.diseaseRepository = diseaseRepository;
        }
        public List<Disease> GetAllDisease()
        {
            return diseaseRepository.GetAll();
        }

        public List<Disease> GetAllDiseaseByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<Disease>();
            }

            return diseaseRepository.GetAllByName(name);
        }

        public Disease GetDiseaseById(long id)
        {
            return diseaseRepository.GetById(id);
        }
    }
}
