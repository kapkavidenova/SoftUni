using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                bool IsBigger = true;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        IsBigger = false;
                        break;
                    }
                }

                if (IsBigger)
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
    }
}
