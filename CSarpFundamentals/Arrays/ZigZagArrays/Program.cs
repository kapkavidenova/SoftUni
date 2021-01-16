using System;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArr = Console.ReadLine()
                    .Split(" ");
                string zeroElement = currentArr[0];
                string firstElement = currentArr[1];

                if (i % 2 == 0)
                {
                    arr1[i] = zeroElement;
                    arr2[i] = firstElement;
                }
                else
                {
                    arr2[i] = zeroElement;
                    arr1[i] = firstElement;
                }
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }   
    }
}
