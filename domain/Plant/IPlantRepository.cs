using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant
{
    public interface IPlantRepository
    {
        List<Plant> GetAll();

        List<Plant> GetAllByName(string name);


    }
}
