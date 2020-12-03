using System;
using System.Linq;

namespace RoundNumber_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = Console.ReadLine().Split( new[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            foreach (var item in x)
            {
                Console.WriteLine(item+"=>"+Math.Round(item,MidpointRounding.AwayFromZero));
            }
        }
    }
}
 