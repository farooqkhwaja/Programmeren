using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4
{
    internal class H4_Shoeseller
    {
        static public void Shoeseller()
        {
            double price = 50;
            int number;

            Console.Write("Hoeveel paar schoenen  wil je kopen?");
            number = int.Parse(Console.ReadLine());

            price = price * number;

            if(number > 2)
            {
                price = price * 0.9;
            }
            

            Console.Write("Hoeveel paar shoenen wilt je kopen? ");
            int shoes = int.Parse(Console.ReadLine());

            if (shoes > 1)
            {
                Console.WriteLine($"Je hebt {shoes} aantal schoenen gekocht.");
            }




        }
    }
}
