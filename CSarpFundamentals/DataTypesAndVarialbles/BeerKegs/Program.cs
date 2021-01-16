using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            double volume = 0;
            double maxVolume = 0;
            string biggestBeer = String.Empty;

            for (int i = 0; i < lines; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * radius * radius * height;

                if (i == 0)
                {
                    volume = maxVolume;
                    model = biggestBeer;
                }
                else if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestBeer = model;
                }
            }

            Console.WriteLine($"{biggestBeer}");
        }
    }
}
