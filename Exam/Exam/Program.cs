using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string x = Console.ReadLine();
            int br = 0;
            while (x != "End of battle!")
            {
                if (energy < int.Parse(x))
                {
                    Console.WriteLine($"Not enought energy. Battles won {br},energy left {energy}.");
                    return;
                }
                if (energy>=int.Parse(x))
                {
                    energy -= int.Parse(x);
                    br++;
                }
                if (br%3==0)
                {
                    energy += br;
                }
                x = Console.ReadLine();
            } 

            Console.WriteLine($"Battles won {br}. Victory!");
        }
    }
}
