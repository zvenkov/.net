﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double doubleNumber = 0;
            int intNumber = 0;
            string stringInput;
            byte entryType;
            Console.Write("Please do the data entry:");
            stringInput = Console.ReadLine();
            bool isDouble = double.TryParse(stringInput, out doubleNumber);
            if (isDouble)
            {
                if (doubleNumber % 1 == 0)
                {
                    intNumber = (int)doubleNumber;
                    entryType = 1;
                }
                else
                {
                    entryType = 2;
                }
            }
            else
            {
                entryType = 3;
            }
            switch (entryType)
            {
                case 1: Console.WriteLine("Integer input. The output is:{0}", intNumber + 1); break;
                case 2: Console.WriteLine("Double input. The output is:{0}", doubleNumber + 1); break;
                case 3: Console.WriteLine("String input. The output is:{0}", stringInput + "*"); break;
            }
        }
    }
}
