using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furnature>[A-Z]*[a-z]*)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";
            string input = Console.ReadLine();
            List<string> furnatures = new List<string>();
            double totalPrice = 0;

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string furnature = match.Groups["furnature"].Value;
                    furnatures.Add(furnature);
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    totalPrice += price * quantity;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Bought furniture:");
            if (furnatures.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnatures));
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
