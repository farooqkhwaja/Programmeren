using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_2
{
    internal class H2_AddUp
    {
        public static void AddUp()
        {

            Console.Write("Wat is het eerste getal?\n> ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wat is het tweede getal?\n> ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"De som is {sum}");
        }
    }
}
