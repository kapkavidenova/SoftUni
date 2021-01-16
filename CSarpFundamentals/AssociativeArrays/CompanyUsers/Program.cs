using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> people = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commands = input.Split(" -> ");
                string company = commands[0];
                string id = commands[1];

                if (!people.ContainsKey(company))
                {
                    people.Add(company, new List<string>());
                }

                if (!people[company].Contains(id))
                {
                    people[company].Add(id);
                }
                input = Console.ReadLine();
            }
            people = people
                .OrderBy(x => x.Key)
                .ThenBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in people)
            {
                Console.WriteLine(item.Key);
                foreach (string id in item.Value)
                {
                    Console.WriteLine(" -- " + id);
                }
            }
        }
    }
}
