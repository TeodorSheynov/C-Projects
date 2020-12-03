using System;

namespace DaysOfWeek_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string [] daysWeek = {"Monday","Thuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
            if (a<1 || a>7)
            {
                Console.WriteLine("Invalid day!");
            }else
            {
                Console.WriteLine(daysWeek[a-1]);
            }
        }
    }
}
