using System;
using System.Linq;

namespace AddAndSubtract_solution
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            AddAndSubtract(x, y, z);
        }

        private static void AddAndSubtract(int x, int y, int z)
        {
            int sum = x + y - z;
            Console.WriteLine(sum);
        }
    }
}
