using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] wagons = new int[num];
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            Console.WriteLine(string.Join(' ', wagons));
            Console.WriteLine(sum);
        }
    }
    }
}
