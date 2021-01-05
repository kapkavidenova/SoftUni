using System;

namespace _11MultiplicationTableTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            do
            {
                int product = num * multiplier;
                Console.WriteLine($"{num} X {multiplier} = {product}");
                multiplier++;
            }
            while (multiplier <= 10);
        }
    }
}
