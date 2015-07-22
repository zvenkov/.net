using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rectangle side:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rectangle side:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Answer is:");
            Console.WriteLine(a * b);
        }
    }
}
