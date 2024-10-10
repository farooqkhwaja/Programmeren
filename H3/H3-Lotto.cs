using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3
{
    internal class H3_Lotto
    {
        public static void Lotto()
        {
            Console.Write("Wat zijn je cijfers (tussen 01 en 45) : ");
            string numbers = Console.ReadLine();
            numbers = numbers.Replace(",", "|");
            string firstPart = numbers.Substring(0, 8);
            string secondPart = numbers.Substring(9, 8);

            Console.WriteLine("Je cijfers zijn: ");
            Console.WriteLine(firstPart);
            Console.WriteLine(secondPart);

        }
    }
}
