using System;
using System.Collections.Generic;

namespace AminerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, int> result = new Dictionary<string, int>();

            while (command != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!result.ContainsKey(command))
                {
                    result.Add(command, 0);
                }
                result[command] += quantity;

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, result.Select(x => ($"{x.Key} -> {x.Value}"))));
        }
    }
}
