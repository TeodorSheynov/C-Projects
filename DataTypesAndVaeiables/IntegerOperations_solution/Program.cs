using System;

namespace IntegerOperations_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c= Convert.ToInt32(Console.ReadLine());
            int d= Convert.ToInt32(Console.ReadLine());
            int sum = (a + b) / c * d;
            Console.WriteLine($"{sum}");
        }
    }
}
