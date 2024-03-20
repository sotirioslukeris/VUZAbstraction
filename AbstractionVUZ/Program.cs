namespace AbstractionVUZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VUZAverage VUZ = new VUZAverage(80,"Prilojno");
            VUZAverage VUZ1 = new VUZAverage(100, "Sistemno");
            Student VUZ3 = new VUZAverage(30, "Hlebar");

            

            List<VUZAverage> students = new List<VUZAverage>
            {
                VUZ,VUZ1
            };

            students.Sort();
            foreach (var item in students)
            {
                Console.WriteLine(item.Print());
            }
        }
    }
}
