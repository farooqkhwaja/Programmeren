using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3
{
    internal class H3_LeetSpeak
    {
        public static void LeetSpeak()
        {
            Console.Write("Geef je tekst in \n> ");
            string leetspeak = Console.ReadLine();

            string textReplacedA = leetspeak.Replace("a", "@");

            Console.WriteLine(textReplacedA);



        }
    }
}
