using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int first = nums[0];

                for (int j = 1; j < nums.Length; j++)
                {
                    int current = nums[j];
                    nums[j - 1] = current;
                }
                nums[nums.Length - 1] = first;
            }
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
