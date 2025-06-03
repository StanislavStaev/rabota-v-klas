using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ku4eshka_sre6ta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first=null;
            Console.WriteLine("Vuvedi ime za purvoto ku4e");
            first=Console.ReadLine();
            Dog dog = new Dog(first);     
            Dog second = new Dog();
            Console.WriteLine("vtoro ime a ku4e");
            string seconddog=Console.ReadLine();
            second.Name = seconddog;
            Dog dog1 = new Dog();
            Dog[] dogs = new Dog[] { dog, second, dog1 };
            foreach (Dog dog2 in dogs) 
            {
             dog2.Bark();
            }
            
        }
    }
}
