using System;
using System.Linq;

namespace MaxSequence_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int br = 0;
            int max=0;
            int element=x[0];
            int total=0;

            for (int i = 0; i < x.Length; i++)
            {
                
                for (int z = i; z <x.Length ; z++)
                {
                    if (x[i] == x[z])
                    {
                        br++;
                        if (br > max)
                        {
                            max = br;
                            element = x[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                
                br = 0;
            }
            for (int i = 0; i < max; i++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
