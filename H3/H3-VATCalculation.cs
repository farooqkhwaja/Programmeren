using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace H3
{
    class H3_VATCalculation
    {
        static public void VatCalculation()
        {
            Console.Write("Geef het bedrag in: ");
            int bedrag = int.Parse(Console.ReadLine());
            Console.Write("Geef BTW percentage in: ");
            int btw = int.Parse(Console.ReadLine());
            int bedragBtw = bedrag + btw;

            Console.WriteLine($"Het bedrag {bedrag} met {btw}% btw bedraagt {bedragBtw}");



        }
    }
}
