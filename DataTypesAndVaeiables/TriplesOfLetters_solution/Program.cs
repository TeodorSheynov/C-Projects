using System;

namespace TriplesOfLetters_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = (int)'a'; i < (int)'a'+ n; i++)
            {
                for (int x = (int)'a'; x < (int)'a'+ n; x++)
                {
                    for (int y = (int)'a'; y < (int)'a'+ n; y++)
                    {
                        Console.WriteLine($"{(char)i}{(char)x}{(char)y}");
                    }
                }
            }
        }
    }
}
