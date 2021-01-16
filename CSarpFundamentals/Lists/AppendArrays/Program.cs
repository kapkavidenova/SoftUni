using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();
            input.Reverse();

            List<string> result = new List<string>();

            foreach (var item in input)
            {
                string[] numbers = item.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var number in numbers)
                {
                    result.Add(number);
                }

            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
