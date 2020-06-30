using System;

namespace Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayOfTheWeek = Console.ReadLine();
            var ages = int.Parse(Console.ReadLine());

            var price = 0;

            if (dayOfTheWeek == "Weekday")
            {
                if (ages >= 0 && ages <= 18)
                {
                    price = 12;
                }
                else if (ages >= 18 && ages <= 64)
                {
                    price = 18;
                }
                else if (ages >= 64 && ages <= 122)
                {
                    price = 12;
                }
            }
            else if (dayOfTheWeek == "Weekend")
            {
                if (ages >= 0 && ages <= 18)
                {
                    price = 15;
                }
                else if (ages >= 18 && ages <= 64)
                {
                    price = 20;
                }
                else if (ages >= 64 && ages <= 122)
                {
                    price = 15;
                }
            }
            else if (dayOfTheWeek == "Holiday")
            {
                if (ages >= 0 && ages <= 18)
                {
                    price = 5;
                }
                else if (ages >= 18 && ages <= 64)
                {
                    price = 12;
                }
                else if (ages >= 64 && ages <= 122)
                {
                    price = 10;
                }
            }
            Console.WriteLine($"{price}$");
        }
    }
}
