using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\s?\+359(\s?-?)2(\1)[0-9]{3}(\1)[0-9]{4}\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(",", matches));
        }
    }
}
