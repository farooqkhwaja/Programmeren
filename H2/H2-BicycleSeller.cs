using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2
{
    internal class H2_BicycleSeller
    {
        public static void BicycleSeller()
        {
            Console.Write("Wat is de inkoopprijs van de fiets?: ");
            double boughtprice = int.Parse(Console.ReadLine());

            Console.Write("Hoeveel procent is de BTW?: ");
            int tax = int.Parse(Console.ReadLine());

            double taxprice = (boughtprice / (double)100) * tax;

            Console.WriteLine("BTW: " + taxprice);


        }
    }
}
