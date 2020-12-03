using System;

namespace WaterOverflow_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int lines = Convert.ToInt32(Console.ReadLine());
            int barrellevel = 0;
            for (int i = 0; i < lines; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if(capacity-x>=0)
                {
                    capacity -= x;
                    barrellevel += x;
                }
                else { Console.WriteLine("Insufficient capacity!"); }
            }
            Console.WriteLine(barrellevel);
        }
    }
}
