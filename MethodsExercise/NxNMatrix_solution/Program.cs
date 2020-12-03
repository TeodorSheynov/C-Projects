using System;

namespace NxNMatrix_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }

        private static void Matrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int z = 0; z < n; z++)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
