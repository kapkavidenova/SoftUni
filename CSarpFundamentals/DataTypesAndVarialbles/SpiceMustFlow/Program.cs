using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalAmountOfSpice = 0;
            int reduceYield = 10;
            int consumedSpice = 26;
            int counterDays = 0;

            while (startingYield >= 100)
            {
                totalAmountOfSpice += startingYield;
                totalAmountOfSpice -= consumedSpice;
                startingYield -= reduceYield;
                counterDays++;
            }

            if (totalAmountOfSpice != 0)
            {
                totalAmountOfSpice -= consumedSpice;
            }

            Console.WriteLine(counterDays);
            Console.WriteLine(totalAmountOfSpice);
        }
    }
}
