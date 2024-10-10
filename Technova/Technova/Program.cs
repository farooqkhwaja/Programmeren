using System.Net.WebSockets;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Technova();
    }
    public static void Technova() 
    { 
        string shopName = "Technova";
        Console.WriteLine($"Welcome to {shopName}");
        Console.WriteLine("-------------------");

        Console.Write("What's your name: ");
        string clientName = Console.ReadLine();

        if (clientName is "")
        {
            Console.WriteLine("Please give us your name.");
            Console.Write("What's your name: ");
            clientName = Console.ReadLine();
        }

        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Hi {clientName}, welcome to {shopName}! Here you can find the newest tech gadgets at a very reasonable price.");
        Console.ResetColor();
        Console.WriteLine("Down here you can see all of our available products\n------------------------------------------------");


        string[] productNames =
        {
            "Razer BlackWidow V4 Pro",
            "Sony WH-1000XM5",
            "Logitech MX Master 3S",
            "ASUS ZenScreen MB16ACV",
            "Anker PowerExpand+ 7-in-1 USB-C Hub"
        };

        decimal[] productPrices =
        {
            199.99m,
            349.99m,
            99.99m,
            229.99m,
            49.99m
        };

        string[] productDescriptions =
        {
            "A premium mechanical keyboard with Razer’s iconic Green Switches for tactile feedback and RGB backlighting.",
            "Top-tier noise-canceling wireless headphones with crystal-clear sound and superior comfort.",
            "An ergonomic wireless mouse designed for productivity with ultra-precise tracking and customizable buttons.",
            "A 15.6-inch portable monitor with a slim design and Full HD resolution for work or entertainment on the go.",
            "A versatile USB-C hub offering 7 ports including HDMI, USB-A, USB-C, and SD card reader for connecting multiple devices."
        };

        DateTime[] releaseDates =
        {
            new DateTime(2023, 2, 1),
            new DateTime(2022, 5, 1),
            new DateTime(2022, 6, 1),
            new DateTime(2021, 4, 1),
            new DateTime(2021, 9, 1)
        };

        int[] stockCounts =
        {
            150,
            200,
            300,
            120,
            500
        };

        for (int i = 0; i < productNames.Length; i++)
        {
            Console.WriteLine($"{i + 1}.Products: {productNames[i]} Stockcount: {stockCounts[i]}");
        }

        Console.WriteLine("\n\n_____1. Look at items \n_____2. Buy items");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("_____3. admin login\n\n");
        Console.ResetColor();

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        if (choice is "1")
        {
            Console.Write("Give the item number that you wanna look into: ");
            int itemnumber = int.Parse(Console.ReadLine());
            Console.Clear();

            if (itemnumber == 1)
            {
                Console.WriteLine("====================================\n\n");
                Console.WriteLine($"Product name: {productNames[0]}");
                Console.WriteLine($"Product price: {productPrices[0]}");
                Console.WriteLine($"Description: {productDescriptions[0]}");
                Console.WriteLine($"Release date: {releaseDates[0]}");
                Console.WriteLine($"Left in stock: {stockCounts[0]}");
            }                                                                                                             
            if (itemnumber == 2)
            {
                Console.WriteLine("====================================\n\n");
                Console.WriteLine($"2. Product name: {productNames[1]}");
                Console.WriteLine($"   Product price: {productPrices[1]}");
                Console.WriteLine($"   Description: {productDescriptions[1]}");
                Console.WriteLine($"   Release date: {releaseDates[1]}");
                Console.WriteLine($"   Left in stock: {stockCounts[1]}\n");
            }                                                                                                              
            if (itemnumber == 3)
            {
                Console.WriteLine("====================================\n\n");
                Console.WriteLine($"3. Product name: {productNames[2]}");
                Console.WriteLine($"   Product price: {productPrices[2]}");
                Console.WriteLine($"   Description: {productDescriptions[2]}");
                Console.WriteLine($"   Release date: {releaseDates[2]}");
                Console.WriteLine($"   Left in stock: {stockCounts[2]}\n");
            }                                                                                                              
            if (itemnumber == 4)
            {
                Console.WriteLine("====================================\n\n");
                Console.WriteLine($"4. Product name: {productNames[3]}");
                Console.WriteLine($"   Product price: {productPrices[3]}");
                Console.WriteLine($"   Description: {productDescriptions[3]}");
                Console.WriteLine($"   Release date: {releaseDates[3]}");
                Console.WriteLine($"   Left in stock: {stockCounts[3]}\n");
            }                                                                                                               
            if (itemnumber == 5)
            {
                Console.WriteLine("====================================\n\n");
                Console.WriteLine($"5. Product name: {productNames[4]}");
                Console.WriteLine($"   Product price: {productPrices[4]}");
                Console.WriteLine($"   Description: {productDescriptions[4]}");
                Console.WriteLine($"   Release date: {releaseDates[4]}");
                Console.WriteLine($"   Left in stock: {stockCounts[4]}\n");
            }
        }
        if (choice == "2")
        {
            Console.Write("Give the item number that you wanna buy: ");
            int itemnumber = int.Parse(Console.ReadLine());

            if (itemnumber == 1)
            { 
                Console.Write("How many of this item you want to buy? ");
                int amountToBuy = int.Parse(Console.ReadLine());

                int numberInStock = stockCounts[0];

                if(numberInStock < amountToBuy)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, we dont have {amountToBuy} items left in the stock.");
                    Console.ResetColor();
                }
                else
                {
                    int stockUpdate = numberInStock - amountToBuy;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You succefully bought {amountToBuy} items!");
                    Console.ResetColor();
                    Console.WriteLine($"We still have {stockUpdate} of item left the stock!");

                    decimal taxRate = 0.21m;
                    decimal priceExTax = productPrices[0] * amountToBuy;
                    decimal priceIncTax = priceExTax + (priceExTax * taxRate);
                    Console.Write($"Total price(tax inclusive):{priceExTax}€ => ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{priceIncTax}€\n\n\n");
                    Console.ResetColor();
                }
            }
            if (itemnumber == 2)
            {
                Console.Write("How many of this item you want to buy? ");
                int amountToBuy = int.Parse(Console.ReadLine());

                int numberInStock = stockCounts[1];

                if (numberInStock < amountToBuy)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, we dont have {amountToBuy} items left in the stock.");
                    Console.ResetColor();
                }
                else
                {
                    int stockUpdate = numberInStock - amountToBuy;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You succefully bought {amountToBuy} items!");
                    Console.ResetColor();
                    Console.WriteLine($"We still have {stockUpdate} of item left the stock!");
                    decimal taxRate = 0.21m;
                    decimal priceExTax = productPrices[1] * amountToBuy;
                    decimal priceIncTax = priceExTax + (priceExTax * taxRate);
                    Console.Write($"Total price(tax inclusive):{priceExTax}€ => ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{priceIncTax}€\n\n\n");
                    Console.ResetColor();
                }
            }
            if (itemnumber == 3)
            {
                Console.Write("How many of this item you want to buy? ");
                int amountToBuy = int.Parse(Console.ReadLine());

                int numberInStock = stockCounts[2];

                if (numberInStock < amountToBuy)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, we dont have {amountToBuy} items left in the stock.");
                    Console.ResetColor();
                }
                else
                {
                    int stockUpdate = numberInStock - amountToBuy;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You succefully bought {amountToBuy} items!");
                    Console.ResetColor();
                    Console.WriteLine($"We still have {stockUpdate} of item left the stock!");
                    decimal taxRate = 0.21m;
                    decimal priceExTax = productPrices[2] * amountToBuy;
                    decimal priceIncTax = priceExTax + (priceExTax * taxRate);
                    Console.Write($"Total price(tax inclusive):{priceExTax}€ => ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{priceIncTax}€\n\n\n");
                    Console.ResetColor();
                }
            }
            if (itemnumber == 4)
            {
                Console.Write("How many of this item you want to buy? ");
                int amountToBuy = int.Parse(Console.ReadLine());

                int numberInStock = stockCounts[3];

                if (numberInStock < amountToBuy)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, we dont have {amountToBuy} items left in the stock.");
                    Console.ResetColor();
                }
                else
                {
                    int stockUpdate = numberInStock - amountToBuy;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You succefully bought {amountToBuy} items!");
                    Console.ResetColor();
                    Console.WriteLine($"We still have {stockUpdate} of item left the stock!");
                    decimal taxRate = 0.21m;
                    decimal priceExTax = productPrices[3] * amountToBuy;
                    decimal priceIncTax = priceExTax + (priceExTax * taxRate);
                    Console.Write($"Total price(tax inclusive):{priceExTax}€ => ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{priceIncTax}€\n\n\n");
                    Console.ResetColor();
                }
            }
            if (itemnumber == 5)
            {
                Console.Write("How many of this item you want to buy? ");
                int amountToBuy = int.Parse(Console.ReadLine());

                int numberInStock = stockCounts[4];

                if (numberInStock < amountToBuy)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, we dont have {amountToBuy} items left in the stock.");
                    Console.ResetColor();
                }
                else
                {
                    int stockUpdate = numberInStock - amountToBuy;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You succefully bought {amountToBuy} items!"); 
                    Console.ResetColor();
                    Console.WriteLine($"We still have {stockUpdate} of item left the stock!");
                    decimal taxRate = 0.21m;
                    decimal priceExTax = productPrices[4] * amountToBuy;
                    decimal priceIncTax = priceExTax + (priceExTax * taxRate);
                    Console.Write($"Total price(tax inclusive):{priceExTax}€ => ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{priceIncTax}€\n\n\n");
                    Console.ResetColor();
                }
            }


        }
        if(choice =="3")
        {
            bool loggedAsAdmin;

            List<string> adminPasswords = new List<string>
            {
                "1234",
                "aaaa",
                "1111"
            };

            Console.Write("Give in a password: ");
            var password = Console.ReadLine();

            if (adminPasswords.Contains(password))
            {
                loggedAsAdmin = true;
                Console.WriteLine("You are looged in as an admin");
                Console.WriteLine("More functionalities are gonna come soon...!");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

            
        }
    }
}