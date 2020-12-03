using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string[] x = Console.ReadLine().Split(" ").ToArray();
            while (x[0].ToLower() != "end")
            {
               
                if (x[0].ToLower()=="add")
                {
                    train.Add(int.Parse(x[1]));   
                }else
                {
                    int z = int.Parse(x[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if(train[i]+z<=capacity)
                        {
                            train[i] += z;
                            break;
                        }else
                        {
                            continue;
                           
                        }
                    }
                }
                Array.Clear(x, 0, x.Length);
                x = Console.ReadLine().Split().ToArray();
            }
            foreach (var item in train)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
