using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete realno chislo:");
            double a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Vavedete cqlo chislo:");
            int b =Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine(a/b);

        }
    }
}
