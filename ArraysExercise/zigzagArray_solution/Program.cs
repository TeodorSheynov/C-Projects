using System;
using System.Linq;
namespace zigzagArray_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            int[] y = new int[n];
            int[] z = new int[2];
            bool flag = true;
            for (int i = 0; i < n; i++)
            {
                z = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if(flag)
                {
                    x[i] = z[0];
                    y[i] = z[1];
                    flag = false;
                }else
                {
                    x[i] = z[1];
                    y[i] = z[0];
                    flag = true;
                }
            }

            foreach (var item in x)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item in y)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
