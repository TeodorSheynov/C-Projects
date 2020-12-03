using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal price = 0;
            List<string> boughtFurniture = new List<string>();

            string patern = @">>([a-zA-z]+)<<((?:\d+)|(?:\d+\.\d{2}))!(\d+)";
            Regex regex = new Regex(patern);
            while (input!="Purchase")
            {
                if (regex.IsMatch(input))
                {
                    Match furnitureMatch = regex.Match(input);
                    boughtFurniture.Add(furnitureMatch.Groups[1].ToString());
                    price += decimal.Parse(furnitureMatch.Groups[2].ToString()) * int.Parse(furnitureMatch.Groups[3].ToString());
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in boughtFurniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {price:f2}");
        }
    }
}
