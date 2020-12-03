using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._HelloFrance
{
    class HelloFrance
    {
        static void Main()
        {
            var x = Console.ReadLine().Split('-','>','|').ToArray();

            foreach (var item in x)
            {
                Console.Write(item+ " ");
            }
        }
    }
}