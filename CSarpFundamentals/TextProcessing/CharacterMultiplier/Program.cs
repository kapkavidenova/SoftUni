using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;
            string longer = input[0];
            string shorter = input[1];

            if (input[0].Length < input[1].Length)
            {
                longer = input[1];
                shorter = input[0];
            }

            for (int i = 0; i < shorter.Length; i++)
            {

                char symbolSh = shorter[i];
                char symbolL = longer[i];
                sum += symbolSh * symbolL;
            }
            for (int i = shorter.Length; i < longer.Length; i++)
            {
                sum += longer[i];
            }

            Console.WriteLine(sum);
        }
    }
}
