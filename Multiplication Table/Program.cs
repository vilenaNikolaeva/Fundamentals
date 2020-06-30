using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number * 2; i++)
            {
                Console.WriteLine($"{number} X {i} ={number*i}");
            }
        }
    }
}
