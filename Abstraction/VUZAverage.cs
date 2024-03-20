using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class VUZAverage:Student
    {


        public VUZAverage(string speciality, double[]score):base(speciality,score)
        {
            
        }



        public override string GetAverage(List<Student>students,double enterScore)
        {
            List<double> listScore = new List<double>();

            foreach (var st in students)
            {
                foreach (var item in st.Score)
                {
                    listScore.Add(item);
                }
            }


            double score = listScore.Average();
            if (enterScore > score)
            {
                return "";
            }
            else
            {
                return $"Average Score : {score}";
            }
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
