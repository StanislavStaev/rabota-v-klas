using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesen_broq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Br");
            int n= int.Parse(Console.ReadLine());
            Danni[] sluzitel = new Danni[n];
            // vuvejdane v Main
            for (int i = 0; i <n; i++) 
            {
                Console.WriteLine($"Slujitel{i+1}");
                sluzitel[i] = new Danni();
                Console.WriteLine("Ime");
                sluzitel[i].Ime=Console.ReadLine();
                Console.WriteLine("Zaplata");
                sluzitel[i].Zaplata=decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("--Spisak--");
            for (int i = 0; i < n; i++) 
            {
                sluzitel[i].Izhod();
            }
        }
    }
}
