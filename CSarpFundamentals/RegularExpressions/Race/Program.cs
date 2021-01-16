using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            Dictionary<string, int> race = new Dictionary<string, int>();

            while (input != "end of race")
            {
                string namePattern = "[A-Za-z]";
                string digitsPattern = @"\d";

                var nameMatch = Regex.Matches(input, namePattern);
                var kmMatch = Regex.Matches(input, digitsPattern);
                var name = String.Concat(nameMatch);
                var sum = kmMatch.Select(x => int.Parse(x.Value))
                    .Sum();

                if (participants.Contains(name))
                {
                    if (race.ContainsKey(name))
                    {
                        race[name] += sum;
                    }
                    else
                    {
                        race.Add(name, sum);
                    }
                }

                input = Console.ReadLine();
            }
            var sorted = race.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");
        }
    }
}
