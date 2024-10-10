using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3
{
    internal class FirstLetterAndSurname
    {
        public static void FirstLetter()
        {
            Console.Write("Geef je naam: ");
            string naam = Console.ReadLine();

            string first = naam.Substring(0,1);
           // string achternaam = naam.Substring();
            Console.WriteLine($"De eerste letter van je naam is: {first}");
        //    Console.WriteLine($"Je achternaam is {achternaam}");


        }
    }
}
