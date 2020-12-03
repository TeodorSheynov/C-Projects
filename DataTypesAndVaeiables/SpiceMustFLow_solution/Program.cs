using System;

namespace SpiceMustFLow_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int node = Convert.ToInt32(Console.ReadLine());
            int brDay = 0;
            int startingYield = 0;
            if (node >= 100)
            {
                

                do
                {
                    startingYield += node;
                    brDay++;  
                    startingYield -= 26;
                    node -= 10;

                } while (node >= 100);
            }
            else { startingYield = 0; }

            if (startingYield >= 26)
            {
                startingYield -= 26;
            }
            else { startingYield = 0; }
            Console.WriteLine(brDay);
            Console.WriteLine(startingYield);
        }
    }
}
