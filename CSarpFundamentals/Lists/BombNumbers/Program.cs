using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
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
                .Split();

            int bombNumber = int.Parse(input[0]);
            int power = int.Parse(input[1]);

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums.Contains(bombNumber))
                {
                    //nums.Remove(bombNumber);
                    int index = nums.IndexOf(bombNumber);

                    int left = index - power;
                    int right = index + power;

                    if (left < 0)
                    {
                        left = 0;
                    }
                    else if (right < 0)
                    {
                        right = 0;
                    }

                    nums.RemoveRange(left, right - left + 1);


                }
            }
            int sum = nums.Sum();
            Console.WriteLine(sum);
        }
    }
}
