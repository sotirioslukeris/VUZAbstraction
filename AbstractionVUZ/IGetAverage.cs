using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionVUZ
{
    public interface IGetAverage
    {
        double GetAverage(List<VUZAverage> students);
    }
}
