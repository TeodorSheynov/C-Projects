using System;
using System.Text.RegularExpressions;

namespace AtctivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            

            string[] comand = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            while (comand[0]!="Generate")
            {
                switch (comand[0])
                {
                    case "Contains":
                        if (x.Contains(comand[1]))
                        {
                            Console.WriteLine($"{x} contains {comand[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        int startIndex = int.Parse(comand[2]);
                        int endIndex = int.Parse(comand[3]);
                        if (comand[1].ToLower()=="upper")
                        {
                            x = x.Substring(0, startIndex) + x.Substring(startIndex, endIndex - startIndex).ToUpper() +
                                x.Substring(endIndex);
                            Console.WriteLine(x);
                        }
                        if (comand[1].ToLower() == "lower")
                        {
                            x = x.Substring(0, startIndex) + x.Substring(startIndex, endIndex - startIndex).ToLower() +
                                x.Substring(endIndex);
                            Console.WriteLine(x);
                        }
                        break;
                    case "Slice":
                        int start = int.Parse(comand[1]);
                        int end = int.Parse(comand[2]);
                        x = x.Remove(start, end - start);
                        Console.WriteLine(x);
                        break;
                    default:
                        break;
                }
                comand= Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Your activation key is: {x}");
            
        }
    }
}
