using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3
{
    internal class H2_CapitalLetters
    {
        public static void CapitalLetters()
        {
            Console.Write("Welke tekst moet ik omzetten? \n> ");
            string capital = Console.ReadLine();

            Console.WriteLine(capital.ToUpper());




        }
    }
}
