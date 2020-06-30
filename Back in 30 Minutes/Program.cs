using System;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = double.Parse(Console.ReadLine());

            minutes += 30;

            while (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }

            while (hours >= 24)
            {
                hours -= 24;
            }
            Console.WriteLine($"{hours}:{minutes}");
        }
    }
}
