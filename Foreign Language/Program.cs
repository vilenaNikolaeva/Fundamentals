using System;

namespace Foreign_Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();

            if (country == "England" || country == "USA")
            {
                Console.WriteLine("English");
            }
            else if (country == "Spain" || country == "Argntina" || country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("uncnown");
            }
        }
    }
}
