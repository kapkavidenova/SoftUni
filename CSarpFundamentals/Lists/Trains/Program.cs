using System;
using System.Collections.Generic;
using System.Linq;

namespace Trains
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    int people = int.Parse(input[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((wagons[i] + people) <= maxCapacity)
                        {
                            wagons[i] += people;
                            break;
                        }
                    }
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); 
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
    
}
