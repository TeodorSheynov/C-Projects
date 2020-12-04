using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Town
    {
        public string Name { get; set; }
        public int People { get; set; }
        public int Gold { get; set; }

        public Town(string name, int people, int gold)
        {
            Name = name;
            People = people;
            Gold = gold;
        }

        public void Plunder(int people, int gold)
        {
            Gold -= gold;
            People -= people; 
            Console.WriteLine($"{Name} plundered! {gold} gold stolen, {people} citizens killed.");
        }
        public void Prosper(int gold)
        {
            if (gold<0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
            }
            else
            {
                Gold += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {Name} now has {Gold} gold.");
            }
        }
    }
}
