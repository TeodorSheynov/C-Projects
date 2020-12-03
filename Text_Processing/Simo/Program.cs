using System;
using System.Collections.Generic;
using System.Linq;

namespace Simo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Условието на задачата тук");
            Console.WriteLine("Името тук");
            
           
           int x = int.Parse(Console.ReadLine());
           int y = int.Parse(Console.ReadLine());
            int[,] array = new int[x,y];
            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < y; k++)
                {
                    array[i, k] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < y; k++)
                {
                    Console.Write($"({i}:{k})-{array[i,k]} ");
                }
                Console.WriteLine();
            }
            int[] startIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] endIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> arrayC = new List<int> { };
            
            for (int i = startIndex[0]; i <= endIndex[0]; i++)
            {
                for (int k = startIndex[1]; k < y; k++)
                {
                    
                    
                    arrayC.Add(array[i, k]);
                    if (i == endIndex[0]&&k==endIndex[1])
                    {
                        break;
                    }
                    
                }
                startIndex[1] = 0;
            }
            foreach (var item in arrayC.OrderBy(t=>t))
            {
                Console.Write($"{item} ");
            }
        }
    }
}
