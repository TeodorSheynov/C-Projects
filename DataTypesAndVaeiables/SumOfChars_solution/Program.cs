using System;

namespace SumOfChars_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char x = Convert.ToChar(Console.ReadLine());
                sum += (int)x;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
