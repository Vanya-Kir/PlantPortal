using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    public interface ITemperatureRepository
    {
        List<Temperature> GetAll();

        List<Temperature> GetAllByUser(string user);

        Temperature GetById(long id);
    }
}
