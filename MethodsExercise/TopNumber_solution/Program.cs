using System;

namespace TopNumber_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNumber(n);

        }

        private static void TopNumber(int n)
        {
            if (n<17)
            {
                return;
            }
            int first=n/10 ;
           
           
            for (int i = 1; i < first; i+=2)
            {
                for (int y = 0; y <10 ; y++)
                {

                    if((i+y)%8==0)
                    {
                        Console.WriteLine($"{i}{y}");
                    }
                }
            }
        }
    }
}
