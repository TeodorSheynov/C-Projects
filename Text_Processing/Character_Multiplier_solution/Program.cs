using System;

namespace Character_Multiplier_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int result = SumStrings(input[0], input[1]);
            Console.WriteLine(result);
        }

        private static int SumStrings(string v1, string v2)
        {
            char[] string1 = v1.ToCharArray();
            char[] string2 = v2.ToCharArray();
            int sum = 0;
            if (v1.Length>v2.Length)
            {
                for (int i = 0; i < v2.Length; i++)
                {
                    sum += (int)string1[i] * (int)string2[i];
                }
                for (int i = v2.Length; i < v1.Length; i++)
                {
                    sum += (int)string1[i];
                }
                return sum;
            }else
            {
                for (int i = 0; i < v1.Length; i++)
                {
                    sum += (int)string1[i] * (int)string2[i];
                }
                for (int i = v1.Length; i < v2.Length; i++)
                {
                    sum += (int)string2[i];
                }
                return sum;
            }
        }
    }
}
