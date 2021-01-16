using System;
using System.Collections.Generic;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];

                if (current != ' ')
                {
                    if (!result.ContainsKey(current))
                    {

                        result[current] = 0;
                    }
                    result[current]++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result.Select(kvp => ($"{kvp.Key} -> {kvp.Value}"))));
        }
    }
}
