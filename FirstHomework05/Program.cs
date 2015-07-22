using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a%b);
        }
    }
}
