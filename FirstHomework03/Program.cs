using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string a = ("Hello World");
            Console.WriteLine("Enter text:");
           string Text = Console.ReadLine();

           if (a == Text)
           {
               Console.WriteLine("Texta savpada!");
           }

           else
           {
               Console.WriteLine("Texta ne suvpada!");
           }
        }
    }
}
