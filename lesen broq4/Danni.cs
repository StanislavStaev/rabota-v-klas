using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lesen_broq4
{
    internal class Danni
    {
        private string ime;
        private decimal zaplata;
        public string Ime
        {
            get {return ime;}
            set {ime = value;}
        }
        public decimal Zaplata
        {
            get{return zaplata;}
            set { zaplata = value;}
        }
        public void Izhod()
        {
            Console.WriteLine($"Slujitel {Ime} zaplata {Zaplata}");
        }
    }
}
