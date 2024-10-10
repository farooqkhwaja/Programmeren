using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace H3
{
    internal class H3_AccessCode
    {
        public static void AccessCode()
        {
            Console.Write("Geef je naam: > ");
            string name = Console.ReadLine();
            Console.Write("Geef je geboortejaar:");
            string birthyear = Console.ReadLine();
            Console.Write("Geef je postcode: ");
            string postcode = (Console.ReadLine());

            string name1 = name.Substring(0 , -2);
            string name2 = name.Substring(0, -1);
            string birthyear1 = birthyear.Substring(0, -1);


        }
    }
}
