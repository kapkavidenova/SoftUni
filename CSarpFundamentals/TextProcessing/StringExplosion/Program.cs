using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    continue;
                }
                if (power > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    power--;
                }
            }
            Console.WriteLine(input);

        }
    }
}
