﻿using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                //int current = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == magicNum)
                    {
                        Console.WriteLine($"{nums[i]} {nums[j]}");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
