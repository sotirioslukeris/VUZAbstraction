using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface IGetAverage
    {
        string GetAverage(List<Student> students,double enterScore);
    }
}
