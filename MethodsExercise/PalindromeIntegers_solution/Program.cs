using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeIntegers_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            do
            {
                
                Palindrome(x);
                x = Console.ReadLine();

            } while (x!="END");
        }

        private static void Palindrome(string x)
        {
            int num =int.Parse(x);
            int[] z = new int[x.Length];
            int[] first = new int[x.Length/2];
            int[] second = new int[x.Length/2];
            for (int i = 0; i < x.Length; i++)
            {
                z[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < x.Length/2; i++)
            {
                first[i] = z[i];
            }
            Array.Reverse(z);
            for (int i = 0; i < x.Length/2; i++)
            {
                second[i] = z[i];
            }
            bool isEqual = Enumerable.SequenceEqual(first, second);
            if (isEqual)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine(); }

        }
    }
}
