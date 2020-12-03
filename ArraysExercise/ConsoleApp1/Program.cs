using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in x)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(x.Sum());
        }
    }
}
