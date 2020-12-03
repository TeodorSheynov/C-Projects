using System;

namespace Elevator_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());
            int capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((int)Math.Ceiling((double)numberOfPeople / capacity));
        }
    }
}
