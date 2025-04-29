using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstrukturen_broq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Br");
            int n = int.Parse(Console.ReadLine());
            Danni4[] sluzitel = new Danni4[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Slujitel{i + 1}");
                Console.WriteLine("Ime");
                string ime=Console.ReadLine();
                Console.WriteLine("Zaplata");
                decimal zaplata=decimal.Parse(Console.ReadLine());
                sluzitel[i]=new Danni4(ime, zaplata);
            }
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"{sluzitel[i].Ime}, zaplata {sluzitel[i].Zaplata} lv");
            }
        }
    }
}
