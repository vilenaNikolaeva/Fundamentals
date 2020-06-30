using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= n * 2; i += 2)
            {
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
