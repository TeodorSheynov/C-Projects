using System;

namespace FactorialDivision_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            FactorielDiv(a, b);
        }

        private static void FactorielDiv(int a, int b)
        {
            int firstNum = 1;
            for (int i = 1; i <= a; i++)
            {
                firstNum *= i;
            }
            int secondNum = 1;
            for (int i = 1; i <=b; i++)
            {
                secondNum *= i;
            }
            Console.WriteLine((firstNum / secondNum).ToString("F"));
        }
    }
}
