using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesOfCodeAndLogic
{
    class Hero
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Mana { get; set; }

        public Hero(string name,int hp,int mana)
        {
            this.Name = name;
            this.Hp = hp;
            this.Mana = mana;
        }
        public void CastSpell(int manaNedded,string spellName)
        {
            if(Mana<manaNedded)
            {
                Console.WriteLine($"{Name} does not have enough MP to cast {spellName}!");
            }else
            {
                int manaLeft = Mana - manaNedded;
                Console.WriteLine($"{Name} has successfully cast {spellName} and now has {manaLeft} MP!");
                Mana = manaLeft;
            }
        }
        public bool TakeDamage(int damage,string attacker)
        {
            int healthleft = this.Hp - damage;
            if (healthleft<=0)
            {
                Console.WriteLine($"{this.Name} has been killed by {attacker}!");
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} was hit for {damage} HP by {attacker} and now has {healthleft} HP left!");
                Hp = healthleft;
                return false;
            }
        }
        public void Recharge(int amount)
        {
            
            if (Mana+ amount> 200)
            {
                Console.WriteLine($"{Name} recharged for {200 - Mana} MP!");
                Mana = 200;
            }
            else
            {
                Mana += amount;
                Console.WriteLine($"{Name} recharged for {amount} MP!");
            }
        }
        public void Heal(int healing)
        {
            
            if (Hp +healing> 100)
            {
               
                Console.WriteLine($"{Name} healed for {100-Hp} HP!");
                Hp = 100;


            }
            else
            {
                Console.WriteLine($"{Name} healed for {healing} HP!");
                Hp += healing;
            }
        }
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"  HP: {Hp}");
            Console.WriteLine($"  MP: {Mana}");
        }

    }
}
