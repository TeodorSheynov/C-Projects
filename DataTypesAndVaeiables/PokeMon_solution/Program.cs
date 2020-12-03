using System;

namespace PokeMon_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int br=0;
          
            if (power % 2 != 0)
            {
                do
                {
                    power -= distance;
                    br++;
                } while (power >= distance);
            }
            else
            {
                int powerExhaustion = power / 2;
                do
                {
                    power -= distance;
                    br++;
                    if (power == powerExhaustion && exhaustion!=0)
                    {
                        power /= exhaustion;
                    }

                } while (power >= distance);
            }
            Console.WriteLine(power);
            Console.WriteLine(br);
        }
    }
}
