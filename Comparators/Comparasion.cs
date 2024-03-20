using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparators
{
    public class Comparasion:IComparable<Comparasion>   
    {
        public double Value { get; set; }

        public string Name { get; set; }


        public Comparasion()
        {
            
        }

        public  int CompareTo(Comparasion other)
        {
            return (Value.CompareTo(other.Value));
        }

        public string Print()
        {
            return $"Model : {this.Name} Value: {this.Value}";
        }
    }
}
