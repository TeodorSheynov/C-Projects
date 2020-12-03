using System;

namespace Print_Sum_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = Convert.ToInt32(Console.ReadLine());
            int finish = Convert.ToInt32(Console.ReadLine());
            int total=0;
            for (int i = start; i <=finish; i++)
            {
                Console.Write($"{i} ");
                total = total + i;
            }
            Console.WriteLine();
            Console.Write($"Sum: {total}");
        }
    }
}
