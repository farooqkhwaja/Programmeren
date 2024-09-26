using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Oefening_2
{
    internal class H2_FuelConsumption
    {
        public static void FuelConsumption()
        {
            Console.Write("Geef het aantal liter in de tank voor de rit: ");
            int amountBeforeTheRide = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef het aantal liter in de tank na de rit: ");
            int amountAfterTheRide = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef de kilometerstand van je auto voor de rit: ");
            int kilometerStandBefore = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef de kilometerstand van je auto na de rit: ");
            int kilometerStandAfter = Convert.ToInt32(Console.ReadLine());

            double consumption = ((double)100 * (amountBeforeTheRide - amountAfterTheRide) / (kilometerStandAfter - kilometerStandBefore  ));
            Console.WriteLine("Het verbruik van je auto is: "+ consumption);

        }
    }
}
