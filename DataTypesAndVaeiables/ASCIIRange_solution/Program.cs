using System;

namespace ASCIIRange_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <=b; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
