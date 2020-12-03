using System;
using System.Collections.Generic;

namespace HouseParty_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> partyList = new List<string>(n);
            for (int i = 0; i < n; i++)
            {
                string[] x = Console.ReadLine().Split();
                switch(x[2])
                {
                    case "going!":
                        if (partyList.Contains(x[0]))
                        {
                            Console.WriteLine($"{x[0]} is already in the list!");
                        }else
                        {
                            partyList.Add(x[0]);
                        }
                        break;
                    case "not":
                        if (!partyList.Contains(x[0]))
                        {
                            Console.WriteLine($"{x[0]} is not in the list!");
                        }
                        else
                        {
                            partyList.Remove(x[0]);
                        }
                        break;
                }
            }
            foreach (var item in partyList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
