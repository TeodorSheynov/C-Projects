using System;
using System.Collections.Generic;
using System.Linq;




namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Town> cities = new Dictionary<string, Town>();
            string[] input = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "Sail")
            {
                
                string name = input[0];
                int population = int.Parse(input[1]);
                int gold = int.Parse(input[2]);
                if (cities.ContainsKey(name))
                {
                    cities[name].Gold += gold;
                    cities[name].People += population;
                }
                else
                {
                    cities.Add(input[0], new Town(name, population, gold));
                }
                
                input = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
            }

            string[] comands = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            while (comands[0]!="End")
            {
                
                
                
                switch (comands[0])
                {
                    case "Plunder":
                        string name = comands[1];
                        int people = int.Parse(comands[2]);
                        int gold = int.Parse(comands[3]);
                        cities[name].Plunder(people, gold);
                        if (cities[name].Gold==0||cities[name].People==0)
                        {
                            Console.WriteLine($"{name} has been wiped off the map!");
                            cities.Remove(name);
                        }
                        break;
                    case "Prosper":
                        int golds = int.Parse(comands[2]);
                        cities[comands[1]].Prosper(golds);
                        break;
                    default:
                        break;
                }
                comands = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }
            if (cities.Count!=0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var item in cities.OrderByDescending(i => i.Value.Gold).ThenBy(i => i.Value.Name))
                {
                    Console.WriteLine($"{item.Value.Name} -> Population: {item.Value.People} citizens, Gold: {item.Value.Gold} kg");
                }
            }else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            
           
        }
    }
}
