using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> goodMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junks = new Dictionary<string, int>();
            goodMaterials["shards"] = 0;
            goodMaterials["fragments"] = 0;
            goodMaterials["motes"] = 0;


            while (true)
            {

                string[] input = Console.ReadLine().Split();

                bool hasToBreak = false;

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        goodMaterials[material] += quantity;


                        if (goodMaterials[material] >= 250)
                        {

                            goodMaterials[material] -= 250;

                            if (material == "shards")
                            {
                                Console.WriteLine($"Shadowmourne obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine($"Valanyr obtained!");
                            }
                            else
                            {
                                Console.WriteLine($"Dragonwrath obtained!");
                            }
                            hasToBreak = true;
                            break;

                        }
                    }
                    else
                    {
                        if (junks.ContainsKey(material) == false)
                        {
                            junks[material] = 0;
                        }
                        junks[material] += quantity;
                    }
                }
                if (hasToBreak)
                {
                    break;
                }
            }
            foreach (var x in goodMaterials
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                string material = x.Key;
                int quantity = x.Value;

                Console.WriteLine($"{material}: {quantity}");
            }
            foreach (var x in junks.OrderBy(x => x.Key))
            {
                string material = x.Key;
                int quantity = x.Value;

                Console.WriteLine($"{material}: {quantity}");
            }
        }
}
