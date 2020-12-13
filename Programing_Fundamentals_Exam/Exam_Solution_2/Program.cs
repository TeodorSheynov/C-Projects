using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Exam_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string validationPattern = @"([*]|[@])([A-Z][a-z]{2,})\1:\s((\[\w\]\|){3}$)";
            Regex validation = new Regex(validationPattern);
            
            string valuesValidation = @"(\[(\w)\]\|)";
            Regex validvalues = new Regex(valuesValidation);

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match newinput = validation.Match(input);
                if (validation.IsMatch(input))
                {
                    input = newinput.Groups[3].ToString();
                    MatchCollection valuesMatched = validvalues.Matches(input);
                    Console.Write($"{newinput.Groups[2]}: ");
                    foreach (Match item in valuesMatched)
                    {
                        byte [] x = Encoding.ASCII.GetBytes(item.Groups[2].ToString());
                        Console.Write($"{x[0]} ");
                    }
                    Console.WriteLine();
                }else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
