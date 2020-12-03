using System;

namespace StrongNumber_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            long factor=1;
            long sum=0;
            string number = Console.ReadLine();
            char[] charArray = number.ToCharArray();
            int[] numbers = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));

            for (long i = 0; i < number.Length; i++)
            {
                for (long n = 1; n <=numbers[i]; n++)
                {
                    factor *=n;
                }
                sum +=factor;
                factor = 1;
            }
            if (sum==Convert.ToInt64(number))
            {
                Console.WriteLine("yes");
            }
            else { Console.WriteLine("no"); }
        }
    }
}
