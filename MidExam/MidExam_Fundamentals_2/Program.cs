using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam_Fundamentals_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int blacklisted = 0;
            int error = 0;
            var names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] comand = Console.ReadLine().Split();
            while (comand[0].ToLower()!="report")
            {
                switch (comand[0].ToLower())
                {
                    case "blacklist":
                        if(names.Contains(comand[1]))
                        {
                            Console.WriteLine($"{names[names.IndexOf(comand[1])]} was blacklisted.");
                            names[names.IndexOf(comand[1])] = "Blacklisted";
                            blacklisted++;
                        }
                        else { Console.WriteLine($"{comand[1]} was not found."); }
                        break;
                    case "error":
                        if (names[int.Parse(comand[1])]=="Blacklisted" || (names[int.Parse(comand[1])] =="Lost"))
                        {
                            break;

                        }
                        else
                        {
                            Console.WriteLine($"{names[int.Parse(comand[1])]} was lost due to an error.");
                            names[int.Parse(comand[1])] = "Lost";
                            error++;
                        }
                        break;
                    case "change":
                        if (names.Count>int.Parse(comand[1]) && int.Parse(comand[1])>=0)
                        {
                            Console.WriteLine($"{names[int.Parse(comand[1])]} changed his username to {comand[2]}.");
                            names[int.Parse(comand[1])] = comand[2];
                        }
                        break;
                    default:
                        break;
                }
                comand = Console.ReadLine().Split();
            }
            
            Console.WriteLine($"Blacklisted names: {blacklisted}");
            Console.WriteLine($"Lost names: {error}");
            foreach (var item in names)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
