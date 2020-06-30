using System;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var n = int.MinValue;

            for (int i = n; i <= number; i++)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
                else if (number % 2 == 1)
                {
                    Console.WriteLine("Please write an even number.");
                    number = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
