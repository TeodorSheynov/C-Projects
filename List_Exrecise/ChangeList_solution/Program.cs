using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] comand = Console.ReadLine().Split().ToArray();
            while (comand[0].ToLower()!="end")
            {
                switch(comand[0].ToLower())
                {
                    case "delete":
                       int z= int.Parse(comand[1]);
                        list.RemoveAll(item => item == z);
                        break;
                    case "insert":
                        list.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                        break;
                    default:
                        break;
                }
                Array.Clear(comand, 0, comand.Length);
                comand= Console.ReadLine().Split().ToArray();
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
