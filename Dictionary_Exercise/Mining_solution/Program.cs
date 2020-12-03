using System;
using System.Collections.Generic;

namespace Mining_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int quantity;
            Dictionary<string, int> minedMaterials = new Dictionary<string, int>();

            while (input!="stop")
            {
                quantity = int.Parse(Console.ReadLine());
                if (minedMaterials.ContainsKey(input))
                {
                    minedMaterials[input] += quantity;
                }else
                {
                    minedMaterials.Add(input, quantity);
                }

                input = Console.ReadLine();
               
            }
            foreach (var material in minedMaterials)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");
            }
        }
    }
}
