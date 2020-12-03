using System;
using System.Linq;
namespace ZigZag_solution
{
    class Program
    {
        static void Main(string[] args)
        {

            var z = Console.ReadLine().Split().ToArray();
            var y = Console.ReadLine().Split().ToArray();
            for (int x = 0; x <y.Length ; x++)
            {
                for (int i = 0; i < z.Length; i++)
                {
                    if (z[i] == y[x])
                    {
                        Console.Write(z[i]+" ");
                    }
                }
            }

        }
    }
}
