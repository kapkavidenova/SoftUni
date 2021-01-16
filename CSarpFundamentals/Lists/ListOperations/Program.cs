using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commands = input.Split();
                string operation = commands[0];

                if (commands[0] == "Add")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Add(number);
                }
                else if (commands[0] == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);

                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (commands[0] == "Remove")
                {
                    int index = int.Parse(commands[1]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }

                }
                else if (commands[0] == "Shift" && commands[1] == "left")
                {
                    int count = int.Parse(commands[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int temp = numbers[0];
                        numbers.Add(temp);
                        numbers.RemoveAt(0);
                    }
                }
                else if (commands[0] == "Shift" && commands[1] == "right")
                {
                    int count = int.Parse(commands[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int temp = numbers[numbers.Count - 1];
                        numbers.Insert(0, temp);
                        numbers.RemoveAt(numbers.Count - 1);
                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
