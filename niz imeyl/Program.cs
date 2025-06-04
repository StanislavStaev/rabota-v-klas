using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niz_imeyl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi email");
            string email=Console.ReadLine();
            int firstIndex= email.IndexOf('@');
            int lastIndex = email.IndexOf("com");
            if (firstIndex -1 >=lastIndex-firstIndex) 
            {
                Console.WriteLine("Call her");
            }
            else
            {
                Console.WriteLine("She is not the one");
            }
        }
    }
}
