using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (times > number && times <= 10)
                {
                    Console.WriteLine($"{number} X {times} = {number * times}");
                    times++;
                    count = 1;
                }
                else if (number > times)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
            if (times > 10 && count == 0)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");

            }
        }
    }
}
