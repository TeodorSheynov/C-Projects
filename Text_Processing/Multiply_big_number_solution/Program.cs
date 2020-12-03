using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiply_big_number_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            List<string> list = x.ToCharArray().Select(z => z.ToString()).ToList();
            
            for (int i = 1; i < list.Count; i++)
            {
                
                if (list[i-1]==list[i])
                {
                    i--;
                    list.RemoveAt(i);
                    
                }
                else
                {
                    continue;
                }

            }
            foreach (var item in list)
            {
                Console.Write(item);
            }

        }
    }
}
