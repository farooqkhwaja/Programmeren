using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3
{
    internal class H3_string_interpolation
    {
        public static void MultiplicationTablesStringInterpolation()
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

            Console.WriteLine($"1 * 11 is {by1}");
            Console.ReadLine();
            Console.WriteLine($"2 * 11 is {by2}");
            Console.ReadLine();
            Console.WriteLine($"3 * 11 is {by3}");
            Console.ReadLine();
            Console.WriteLine($"4 * 11 is {by4}");
            Console.ReadLine();
            Console.WriteLine($"5 * 11 is {by5}");
            Console.ReadLine();
            Console.WriteLine($"6 * 11 is {by6}");
            Console.ReadLine();
            Console.WriteLine($"7 * 11 is {by7}");
            Console.ReadLine();
            Console.WriteLine($"8 * 11 is {by8}");
            Console.ReadLine();
            Console.WriteLine($"9 * 11 is {by9}");
            Console.ReadLine();
            Console.WriteLine($"10 * 11 is {by10}");
            Console.ReadLine();

        }
        public static void SpaceStringInterpolation()
        {
            Console.WriteLine("Welcome to space!");
            Console.ReadLine();

            double mercurius = 0.38;
            double venus = 0.91;
            double aarde = 1.00;
            double mars = 0.38;
            double jupiter = 2.34;
            double saturnus = 1.06;
            double uranus = 0.92;
            double neptinus = 1.19;
            double pluto = 0.06;

            Console.Write("Geef je gewicht in: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Op Mercurius voel je je alsof {age * mercurius}kg weegt.");
            Console.WriteLine($"Op Venus voel je je alsof {age * venus}kg weegt.");
            Console.WriteLine($"Op Aarde voel je je alsof {age * aarde}kg weegt.");
            Console.WriteLine($"Op Mars voel je je alsof {age * mars}kg weegt.");
            Console.WriteLine($"Op Jupiter voel je je alsof {age * jupiter}kg weegt.");
            Console.WriteLine($"Op Saturnus voel je je alsof {age * saturnus}kg weegt.");
            Console.WriteLine($"Op Uranus voel je je alsof {age * uranus}kg weegt.");
            Console.WriteLine($"Op Neptunus voel je je alsof {age * neptinus}kg weegt.");
            Console.WriteLine($"Op Pluto voel je je alsof {age * pluto}kg weegt.");

        }
    }
}
