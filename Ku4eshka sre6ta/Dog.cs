using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ku4eshka_sre6ta
{
    internal class Dog
    {
        private string name;
        public Dog() 
        {
            this.name = "Balkan";
        }
        public Dog(string name) 
        {
        this.name= name;
        }
        public string Name
        {
            get { return name; } 
            set { name = value; }
        }
        public void Bark()
        {
            Console.WriteLine("ku4eto kaza bau bau i negovoto ime e {0}",name);
        }
    }
}
