using System;
using System.Linq;

namespace National_court
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[3];
            for (int i = 0; i < 3; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }
            int people = int.Parse(Console.ReadLine());
            int hours = 0;

            hours += people / x.Sum();
            if (people%x.Sum()!=0)
            {
                hours += hours / 3;
            }
            

            if (people % x.Sum() != 0)
            {
                hours++;
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
