using System;
using System.Linq;

namespace EqualSums_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int []x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool aa = false;
            if (x.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
                for (int i = 0; i < x.Length; i++)
                {
                    int sumleft = 0;
                    int sumright = 0;



                    for (int z = 0; z < i; z++)
                    {
                        sumleft += x[z];
                    }

                    for (int y = i; y < x.Length; y++)
                    {
                        sumright += x[y];
                    }
                    if (sumleft == sumright - x[i])
                    {
                    aa = true;
                        Console.WriteLine($"{i}");
                        return;

                    }
                    
                }
            Console.WriteLine("no");
        }
    }
}
