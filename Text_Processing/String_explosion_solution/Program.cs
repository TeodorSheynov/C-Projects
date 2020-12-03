using System;
using System.Collections.Generic;
using System.Linq;

namespace String_explosion_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            List<string> input = x.ToCharArray().Select(z => z.ToString()).ToList();
            int power = 0;
            int tryIt;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == ">")
                {

                    i++;
                    do
                    {
                        if (int.TryParse(input[i], out tryIt))
                        {
                            power += int.Parse(input[i]);
                            input.RemoveAt(i);
                            power--;
                            i--;
                        }
                        else if (input[i] == ">")
                        { 
                                i++;
                        }else
                        {
                            input.RemoveAt(i);
                            power--;
                            i--;
                        }
                        if (power>input.Count-i)
                        {
                            power = input.Count - i; ;
                        }

                    } while (power > 0);
                }
            }
            foreach (var item in input)
            {
                Console.Write(item);
            }
        }
    }
}
