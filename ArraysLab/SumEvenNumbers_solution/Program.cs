using System;
using System.Linq;

namespace SumEvenNumbers_solution
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int []even  = x.Where((index) => index % 2 == 0).ToArray();
            Console.WriteLine(even.Sum());

        }
    }
}
