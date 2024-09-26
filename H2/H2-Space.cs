using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    internal class H2_Space
    {
        public static void Space()
        {
            Console.WriteLine("Welcome to space!");
            Console.ReadLine();

            double mercurius = 0.38;
            double venus = 0.91;
            double aarde = 1.00;
            double mars = 0.38;
            double jupiter = 2.34;
            double daturnus = 1.06;
            double uranus = 0.92;
            double neptinus = 1.19;
            double pluto = 0.06;

            Console.Write("Geef je gewicht in: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Op mercurius voel je je alsof "+ (age * mercurius)+ "kg weegt.");
            Console.WriteLine("Op venus voel je je alsof " + (age * venus) + "kg weegt.");
            Console.WriteLine("Op aarde voel je je alsof " + (age * aarde) + "kg weegt.");
            Console.WriteLine("Op mars voel je je alsof " + (age * mars) + "kg weegt.");
            Console.WriteLine("Op jupiter voel je je alsof " + (age * jupiter) + "kg weegt.");
            Console.WriteLine("Op daturnus voel je je alsof " + (age * daturnus) + "kg weegt.");
            Console.WriteLine("Op uranus voel je je alsof " + (age * uranus) + "kg weegt.");
            Console.WriteLine("Op neptinus voel je je alsof " + (age * neptinus) + "kg weegt.");
            Console.WriteLine("Op pluto voel je je alsof " + (age * pluto) + "kg weegt.");


        }
    }
}
