using System;

namespace SumDigits_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int b = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            do
            {
                sum = sum + (b % 10);
                b = b / 10;
            } while (b!=0);
            Console.WriteLine(sum);
        }
    }
}
