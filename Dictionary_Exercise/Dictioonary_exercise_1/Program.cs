using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictioonary_exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Dictionary<char, int> charOccurance = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char[] inputChar = input[i].ToCharArray();
                for (int j = 0; j <input[i].Length ; j++)
                {
                    if (charOccurance.ContainsKey(inputChar[j]))
                    {
                        charOccurance[inputChar[j]]++;
                    }else
                    {
                        charOccurance.Add(inputChar[j], 1);
                    }
                }

            }
            foreach (var character in charOccurance)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
