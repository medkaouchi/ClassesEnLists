using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEnLists
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Prijzen = new double[20];
            for (int i = 0; i < Prijzen.Length; i++)
            {
                Console.Write($"Prijs {i+1}: ");
                Prijzen[i] = Convert.ToDouble(Console.ReadLine());
            }
            foreach (var item in Prijzen)
            {
                if(item>=5)
                    Console.WriteLine(item+" euro");
            }
            Console.WriteLine($"Het gemiddelde: {Prijzen.Average()} euro.");
            Console.ReadLine();
        }
    }
}
