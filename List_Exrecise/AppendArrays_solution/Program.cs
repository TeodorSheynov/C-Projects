using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays_solution
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> result = new List<int>();

            List<string> numbersAsStrings = Console.ReadLine()
                                .Split('|')
                                .Reverse()
                                .ToList();
            foreach (var str in numbersAsStrings)
            {
                result.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList()
                                     );
            }
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
