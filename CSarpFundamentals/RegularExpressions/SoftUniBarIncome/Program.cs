using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z]{1}[a-z]+)%[^|%$\.]*<(\w+)>[^|%$\.]*\|(\d+)\|[^|%$\.]*?(\d+\.?\d*)\$";
            string input = Console.ReadLine();
            double total = 0;

            while (input != "end of shift")
            {

                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);
                    double sum = count * price;
                    total += sum;
                    Console.WriteLine($"{name}: {product} - {sum:f2}");
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");

        }
    }
}
