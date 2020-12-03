using System;
using System.Collections.Generic;
using System.Linq;






namespace HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> hero = new Dictionary<string, Hero>();
            // adding heroes to Dictionary to store
            for (int i = 0; i < n; i++)
            {
                string[] parameters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                hero.Add(parameters[0], new Hero(parameters[0], int.Parse(parameters[1]), int.Parse(parameters[2])));
            }
            //reading input of commands
            string[] comands = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);

            while (comands[0] != "End")
            {

                //read the comand
                switch (comands[0])
                {
                    case "Heal":
                        hero[comands[1]].Heal(int.Parse(comands[2]));
                        break;
                    case "Recharge":
                        hero[comands[1]].Recharge(int.Parse(comands[2]));
                        break;
                    case "TakeDamage":
                        if (hero[comands[1]].TakeDamage(int.Parse(comands[2]), comands[3]))
                        {
                            hero.Remove(comands[1]);
                        }
                        break;
                    case "CastSpell":
                        hero[comands[1]].CastSpell(int.Parse(comands[2]), comands[3]);
                        break;
                }
             //read next comand
             comands = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in hero.OrderByDescending(x=>x.Value.Hp).ThenBy(x=>x.Value.Name))
            {
                item.Value.Print();
            }
        }
    }
}

