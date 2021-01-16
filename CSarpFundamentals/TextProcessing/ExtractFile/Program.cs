﻿using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');

            var file = input[input.Length - 1].Split('.');
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
