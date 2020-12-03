using System;
using System.Collections.Generic;
using System.Linq;

namespace Gaus_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            int x = n.Count / 2;
            for (int i = 0; i < x; i++)
            {
                n[i] = n[i] + n.Last();
                n.RemoveAt(n.LastIndexOf(n.Last()));

            }
            Console.WriteLine(string.Join("",n));
        }
    }
}
