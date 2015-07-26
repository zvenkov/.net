using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework01
{
    class Program
    {
        static void Main(string[] args)
        { int n;
            Console.Write("Vuvedete nomer:");
            bool isnInt = int.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (((i % 3) != 0) || ((i % 7) != 0))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Deli se na 7 i 3!");
            }
        }
    }
}
