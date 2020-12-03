using System;
using System.Linq;

namespace ReverseArrayOfStrings_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Array.Reverse(x);
            foreach (var item in x)
            {
                Console.Write(item+" ");
            }
        }
    }
}
