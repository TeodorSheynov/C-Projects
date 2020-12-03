using System;
using System.Linq;
namespace EqualArrays_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var y = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = Enumerable.SequenceEqual(x, y);
            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical.Sum: {x.Sum()}");
            }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if(x[i]!=y[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    }
                }
            }
        }
    }
}
