using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace H4
{
    internal class H4_StemWijzer
    {
        static public void Stemwijzer()
        {
            Console.Write("Werk je veel? ");
            string answer = Console.ReadLine();

            if(answer == "ja")
            {
                Console.Write("Koop je soms brood? ");
                answer = Console.ReadLine();
                if(answer == "ja")
                {
                    Console.Write("Ben je een seut? ");
                    answer = Console.ReadLine();
                    if(answer == "ja")
                    {
                        Console.WriteLine("Cdv");
                    }
                    else if(answer == "nee")
                    {
                        Console.Write("Heb je vrienden?");
                        answer = Console.ReadLine();
                        if(answer == "nee")
                        {
                            Console.WriteLine("Nva");
                        }
                        else if (answer == "ja")
                        {
                            Console.Write("Staat jouw wagen, huis,.. op naam van jouw ouders? ");
                            answer = Console.ReadLine();
                            if(answer == "ja")
                            {
                                Console.WriteLine("open vld");
                            }
                            else if(answer == "nee")
                            {
                                Console.WriteLine("Blanco");
                            }
                        }
                    }
                }
            }
            else if(answer == "nee")
            {
                Console.Write("Eet je vaak Quinoa? ");
                answer = Console.ReadLine();
                if (answer == "ja")
                {
                    Console.WriteLine("groen");

                }
                else if(answer == "ja")
                {
                    Console.Write("Krijg je vaak schuf van alles? ");
                    answer = Console.ReadLine();
                    if(answer == "ja")
                    {
                        Console.WriteLine("Sp.a");
                    }
                    else if(answer == "nee")
                    {
                        Console.Write("Geloof je nog in sinterklaas?");
                        answer = Console.ReadLine();
                        if(answer == "ja")
                        {
                            Console.WriteLine("Pvda");
                        }
                        else if(answer == "nee")
                        {
                            Console.WriteLine("Blanco");
                        }
                    }
                }
            }
        }
    }
}
