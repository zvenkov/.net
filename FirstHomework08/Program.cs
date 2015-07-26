using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete text 1:");
            string a = Console.ReadLine();
            Console.WriteLine("Vavedete text 2:");
            string b = Console.ReadLine();

            if (a != b )
            {
                Console.WriteLine("Texta ne suvpada!");
            }

            else
            {
                Console.WriteLine("Texta suvpada!");
            }
        }
    }
}
