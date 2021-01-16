using System;
using System.Collections.Generic;
using System.Linq;


namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string name = commands[0];

                if (commands.Length == 4)
                {
                    if (!guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                }
                else if (commands.Length == 3)
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
