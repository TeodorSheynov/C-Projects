using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> inputList = new List<string>();

            StringBuilder stringBuilder = new StringBuilder();
            

            while (comand[0]!="End")
            {
                switch (comand[0])
                {
                    case "Translate":
                        stringBuilder.Append(input);
                        input = stringBuilder.Replace(comand[1], comand[2]).ToString();
                        Console.WriteLine(input);
                        stringBuilder.Clear();
                        break;
                    case "Includes":
                        if (input.Contains(comand[1]))
                        {
                            Console.WriteLine("True");
                        }else
                        { Console.WriteLine("False"); }
                        break;
                    case "Start":
                        if (input.StartsWith(comand[1]))
                        {
                            Console.WriteLine("True");
                        }else
                        { Console.WriteLine("False"); }
                        break;
                    case "Lowercase":
                        
                        input = input.ToLower();
                        Console.WriteLine(input);
                        break;
                    case "FindIndex":
                        
                        Console.WriteLine(input.LastIndexOf(comand[1]));
                        break;
                    case "Remove":
                        stringBuilder.Append(input);
                        stringBuilder.Remove(int.Parse(comand[1]), int.Parse(comand[2]));
                        input = stringBuilder.ToString();
                        Console.WriteLine(input);
                        stringBuilder.Clear();
                        break;

                    default:
                        break;
                }
                comand= Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
