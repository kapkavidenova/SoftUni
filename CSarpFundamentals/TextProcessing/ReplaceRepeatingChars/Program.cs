﻿using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToString();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input = input.Remove(i, 1);
                    i--;

                }
            }
            Console.WriteLine(string.Join("", input));
        }
    }
}
