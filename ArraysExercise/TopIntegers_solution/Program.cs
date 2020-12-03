using System;
using System.Linq;
using System.Collections.Generic;

namespace TopIntegers_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

           
            for (int i = 0; i < x.Length; i++)
            {
                bool isTop = true;
                for (int z =i+1; z <x.Length ; z++)
                {
                   
                    if (x[i]<=x[z])
                    {

                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    Console.Write($"{x[i]} ");
                }
            }
        }
    }
}
