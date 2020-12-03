using System;
using System.Collections.Generic;

namespace Orders_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<decimal>> products = new Dictionary<string, List<decimal>>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0]!="buy")
            {
                string key = input[0];
                decimal price = decimal.Parse(input[1]);
                decimal quantity = decimal.Parse(input[2]);
                if (!products.ContainsKey(input[0]))
                {
                    products.Add(key,new List<decimal>() {price,quantity});
                }
                else
                {
                    products[key][0] = price;
                    products[key][1] += quantity;
                }
                
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0]*product.Value[1]):f2}");
            }

        }
    }
}
