using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesni_masivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[]a =new double[4];
            for (int i = 0; i < 4; i++)
            {
                a[i] =double.Parse(Console.ReadLine());
            }
            //izhod 1
            Console.WriteLine("normalen");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]);
            }
            Array.Sort(a);
            //izhod 2
            Console.WriteLine("nenormalen");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]);
            }
            //izhod 3
            Array.Reverse(a);
            Console.WriteLine("o6te po-nenormalen");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]);
            }
            //izhod 4
            int pos = 1;
            int countOfZero = 1;
            Array.Sort(a,pos,countOfZero);
            Console.WriteLine("naj-nenormalen");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
