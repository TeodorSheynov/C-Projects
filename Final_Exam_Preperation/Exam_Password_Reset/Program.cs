using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string result = string.Empty;
            StringBuilder builder = new StringBuilder();
            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> oddComand = new List<string>();
            

            while (command[0]!="Done")
            {
                switch (command[0].ToLower())
                {
                    case "takeodd":
                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i%2!=0)
                            {
                                builder.Append(password[i]);
                            }
                        }
                        Console.WriteLine(builder.ToString());
                        password = builder.ToString();
                        builder.Clear();
                        break;
                    case "cut":
                        oddComand = password.ToCharArray().Select(x => x.ToString()).ToList<string>();
                        oddComand.RemoveRange(int.Parse(command[1]), int.Parse(command[2]));
                        foreach (var item in oddComand)
                        {
                            builder.Append(item);
                        }
                        Console.WriteLine(builder.ToString());
                        password = builder.ToString();
                        builder.Clear();
                        oddComand.Clear();
                        break;
                    case "substitute":
                        if (password.Contains(command[1]))
                        {
                            while (password.Contains(command[1]))
                            {
                                password = password.Replace(command[1], command[2]);
                            }
                            Console.WriteLine(password);
                        }else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                    default:
                        break;
                }
                command= Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
