using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparasion car1 = new Comparasion()
            {
                Name = "Volkswagen",
                Value = 20000.50
            };

            Comparasion car2 = new Comparasion()
            {
                Name = "BMW",
                Value = 15700.50
            };

            List<Comparasion> list = new List<Comparasion> { car1,car2};

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item.Print()); 
            }
        }
    }
}
