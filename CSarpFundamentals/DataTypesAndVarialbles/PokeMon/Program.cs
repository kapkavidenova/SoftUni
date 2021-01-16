using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int currentPower = powerN;
            int counterTargets = 0;

            while (currentPower >= distanceM)

            {
                currentPower -= distanceM;
                counterTargets++;

                if (currentPower == powerN / 2 && exhaustionFactorY != 0)
                {
                    currentPower /= exhaustionFactorY;
                }
            }
            Console.WriteLine(currentPower);
            Console.WriteLine(counterTargets);
        }
    }
}
