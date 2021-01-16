using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cards1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> cards2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            while (cards1.Count != 0 && cards2.Count != 0)
            {
                int first1 = cards1[0];
                int first2 = cards2[0];

                if (first1 > first2)
                {
                    cards1.Add(first1);
                    cards1.Add(first2);
                }

                else if (first1 < first2)
                {
                    cards2.Add(first2);
                    cards2.Add(first1);
                }
                cards1.RemoveAt(0);
                cards2.RemoveAt(0);

            }
            if (cards1.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {cards2.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {cards1.Sum()}");
            }
        }
    }
}
