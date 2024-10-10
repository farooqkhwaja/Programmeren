using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3
{
    class H3_SumOfNumbers
    {
        public static void SumOfNumbers()
        {
            Console.Write("Geef je e-mailadres:\n> ");
            string emailAdres = Console.ReadLine();

            Console.WriteLine($"Je naam uit je e-mail is :{emailAdres.ToUpper()}");


        }
    }
}
