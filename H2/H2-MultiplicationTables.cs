using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    internal class H2_MultiplicationTables
    {
        public static void MultiplcationTables()
        {
            int by1 = 411 * 1;
            int by2 = 411 * 2;
            int by3 = 411 * 3;
            int by4 = 411 * 4;
            int by5 = 411 * 5;
            int by6 = 411 * 6;
            int by7 = 411 * 7;
            int by8 = 411 * 8;
            int by9 = 411 * 9;
            int by10 = 411 * 110;

            Console.WriteLine($"1 * 411 is {by1}");
            Console.ReadLine();
            Console.WriteLine("2 * 411 is " + by2);
            Console.ReadLine();
            Console.WriteLine("3 * 411 is " + by3);
            Console.ReadLine();
            Console.WriteLine("4 * 411 is " + by4);
            Console.ReadLine();
            Console.WriteLine("5 * 411 is "+ by5);
            Console.ReadLine();
            Console.WriteLine("6 * 411 is " + by6);
            Console.ReadLine();
            Console.WriteLine("7 * 411 is " + by7);
            Console.ReadLine();
            Console.WriteLine("8 * 411 is " + by8);
            Console.ReadLine();
            Console.WriteLine("9 * 411 is " + by9);
            Console.ReadLine();
            Console.WriteLine("10 * 411 is " + by10);
            Console.ReadLine();

            int number = 411;

            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{i} * {number} is {result}");
                Console.ReadLine();
            }
        }
    }
}