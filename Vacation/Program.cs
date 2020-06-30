using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numPeople = int.Parse(Console.ReadLine());
            var groupType = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();

            var price = 0.0;
            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    if (numPeople < 30)
                    {
                        price = 8.45 * numPeople;
                    }
                    else
                    {
                        price = Math.Abs((8.45 * numPeople) * 0.15) - (8.45 * numPeople);
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    if (numPeople < 30)
                    {
                        price = 9.80 * numPeople;
                    }
                    else
                    {
                        price = Math.Abs((9.80 * numPeople) * 0.15) - (9.80 * numPeople);
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    if (numPeople < 30)
                    {
                        price = 10.46 * numPeople;
                    }
                    else
                    {
                        price = Math.Abs((10.46 * numPeople) * 0.15) - (10.46 * numPeople);
                    }
                }
            }
            else if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    if (numPeople < 100)
                    {
                        price = 10.90 * numPeople;
                    }
                    else
                    {
                        price = Math.Abs(10.90 * (numPeople - 10));
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    if (numPeople < 100)
                    {
                        price = 15.50 * numPeople;
                    }
                    else
                    {
                        price = Math.Abs(15.60 * (numPeople - 10));
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    if (numPeople < 100)
                    {
                        price = 16 * numPeople;
                    }
                    else
                    {
                        price = Math.Abs(16 * (numPeople - 10));
                    }
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    if (numPeople <= 10 && numPeople >= 20)
                    {
                        price = 15 * numPeople;
                    }
                    else
                    {
                        price = ((15 * numPeople) * 0.05) - (15 * numPeople);
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    if (numPeople <= 10 || numPeople >= 20)
                    {
                        price = 20 * numPeople;
                    }
                    else
                    {
                        price = (20 * (numPeople) * 0.05) - (20 * numPeople);
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    if (numPeople <= 10 && numPeople >= 20)
                    {
                        price = 22.50 * numPeople;
                    }
                    else
                    {
                        price = Math.Abs(22.50 * (numPeople) * 0.05) - (22.50 * numPeople);
                    }
                }
            }
            Console.WriteLine($"Total price: {Math.Abs(price)}");
        }
    }
}
