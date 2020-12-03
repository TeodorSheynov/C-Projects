using System;

namespace CharactersInRange_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            char a =char.Parse(Console.ReadLine());
            char b= char.Parse(Console.ReadLine());
            AsciiRange(a, b);
        }

        private static void AsciiRange(char a,char b)
        {
            if ((int)a>(int)b)
            {
                for (int i = (int)b + 1; i < (int)a; i++)
                {
                    Console.Write(string.Join(" ", (char)i));
                }
            }
            else
            {
                for (int i = (int)a + 1; i < (int)b; i++)
                {
                    Console.Write($"{(char)i}");
                }
            }
           
        }
    }
}
