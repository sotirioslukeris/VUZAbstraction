using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionVUZ
{
    public class VUZAverage:Student,IComparable<VUZAverage>
    {
        private List<Student> scores;


        public VUZAverage(double score,string speciality):base(score,speciality)
        {
           
        }
        

        public int CompareTo(VUZAverage? other)
        {
            if (other == null)
            {
                return 1;
            }
            return speciality.CompareTo(other.speciality);
        }


        public override double GetAverage(List<VUZAverage> students)
        {
            return students.Average(x => x.score);
        }

       

    }
}
