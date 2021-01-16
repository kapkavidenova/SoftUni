using System;
using System.Collections.Generic;
using System.Linq;



namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                switch (input[0])
                {
                    case "Delete":
                        int number = int.Parse(input[1]);
                        nums.RemoveAll(x => x == number);
                        break;
                    case "Insert":
                        int index = int.Parse(input[2]);
                        int number2 = int.Parse(input[1]);
                        nums.Insert(index, number2);
                        break;
                }

                input = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
