using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstraction
{
    public class Output:Student
    {


        public Output(string name, string faculty, int facNum, string speciality, string group, double[] scores):
            base(name, faculty, facNum, speciality, group,scores)
        {
                
        }
        public override string Print()
        {
            {
                return $"Student : {Name}\nFaculty : {Faculty}\nFaculty number : {FacNum}" +
                $"\nSpeciality : {Speciality}\nGroup : {Group}\nScore : {string.Join(" ", score)}";
            }
        }

        public override string GetAverage(List<Student> students, double enterScore)
        {
            throw new NotImplementedException();    
        }
    }
}
