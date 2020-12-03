using System;
using System.Collections.Generic;
using System.Linq;


namespace MiddleCharacters_solution
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            MiddleChar(x);
        }

        private static void MiddleChar(string x)
        {
            List<char> z = x.ToList();
            if(x.Length%2==0)
            {
                int mid1 = (x.Length / 2 - 1);
                int mid2 = (x.Length / 2 );

                Console.WriteLine($"{z[mid1]}{z[mid2]}");
            }else
            {
                double mid = (double)x.Length / 2;
                Math.Ceiling(mid);
                Console.WriteLine(z[(int)mid]);
            }
        }
    }
}
