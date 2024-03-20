using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] scoreSt1 = new double[]
            {
                100,200,50,60,80
            };
                Student st1 = new Output("Ben", "IT Geeks", 029321, "Programming", "System", scoreSt1);
                double[] scoreSt2 = new double[]
                {
                40,230,120,80,60
                };

                Student st2 = new Output("John", "Marketing Geniuses", 082381, "Marketing", "Worldwide", scoreSt2);

                Student VUZ1 = new VUZAverage(st1.Speciality, st1.Score);

                Student VUZ2 = new VUZAverage(st2.Speciality, st2.Score);

                List<Student> students = new List<Student> { st1, st2 };
                students.Sort();

                students.ForEach(x => Console.WriteLine(x.Print()));


                List<Student> averageScore = new List<Student> { VUZ1, VUZ2 };
                Console.WriteLine(VUZ1.GetAverage(averageScore, 80));
            }
            catch (ArgumentNullException)
            {
               
                
            }
            catch(NotImplementedException)
            {

            }
            
        }
    }
}
