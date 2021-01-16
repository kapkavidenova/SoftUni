using System;
using System.Linq;

namespace MaxSequanceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToArray();

            int maxCounter = 0;
            int counter = 1;
            int startIndex = 0;
            int bestIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] == nums[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                    startIndex = i;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    bestIndex = startIndex;
                }
            }

            for (int i = bestIndex; i < bestIndex + maxCounter; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
