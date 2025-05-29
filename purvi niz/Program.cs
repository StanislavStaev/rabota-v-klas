using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purvi_niz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi edno izre4enie  ");
            string str1=Console.ReadLine();
            Console.Write("Vuvedi vtoro izre4enie  ");
            string str2 = Console.ReadLine();
            int result=string.Compare(str1, str2, 0);
            Console.WriteLine(result);
            string str3 = " Hristozova";
            string str = str1+" "+ str2 + str3;
            string s = str + "-"+str1;
            Console.WriteLine(s);
            char str4 = 'K';
            Console.WriteLine(str4);
            var builder= new StringBuilder(60);
            builder.Append("Az sum Kiro i dnes rabotq i 6te spasq cqlata grupa");
            builder[7] = 'T';
            builder.Remove(7,4);
            builder.Insert(7,"Stanislav");
            Console.WriteLine(builder);
            builder.Replace("rabotq","skatavam");
            builder.Remove(7,9);
            Console.WriteLine(builder);
            str1.Insert(8, " Hristozova");
            Console.WriteLine(str1);
            string str5 = str2.Replace("+", "and");
            Console.WriteLine(str5);
            string a = str1.ToLower();
            Console.WriteLine(a);
            string b = str3.ToUpper();
            Console.WriteLine(b);
            string c=str2.Remove(28, 6);
            c=str2.Remove(0,19);
            Console.WriteLine(c);
        }
    }
}
