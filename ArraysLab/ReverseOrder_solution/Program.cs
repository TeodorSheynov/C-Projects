using System;
using System.Linq;

namespace ReverseOrder_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a=new string[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Console.ReadLine();
            }
            Array.Reverse(a);
            foreach (string i in a)
            {
                Console.Write($"{i} ");
            }
           
         
        }
    }
}
