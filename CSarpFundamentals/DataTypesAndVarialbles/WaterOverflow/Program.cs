using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int totalLiters = 0;

            for (int i = 1; i <= n; i++)
            {
                int pourLiters = int.Parse(Console.ReadLine());

                if (pourLiters > (capacity - totalLiters))
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    totalLiters += pourLiters;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
