using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] currentProduct = input.Split();
                string product = currentProduct[0];
                double price = double.Parse(currentProduct[1]);
                double quantity = int.Parse(currentProduct[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<double>() { price, quantity });
                }
                else
                {
                    products[product][0] = price;
                    products[product][1] += quantity;
                }

                input = Console.ReadLine();
            }
            foreach (var item in products)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
