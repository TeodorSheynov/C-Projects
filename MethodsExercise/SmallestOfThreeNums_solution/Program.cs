using System;

namespace SmallestOfThreeNums_solution
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            BigOfThree(x, y, z);
        }

        private static void BigOfThree(int x, int y, int z)
        {
            if (x < y && x<z)
            {
                Console.WriteLine(x);
            }
            else if(y<x && y<z)
            {
                Console.WriteLine(y);
            }else
            {
                Console.WriteLine(z);
            }
            
        }
    }
}
