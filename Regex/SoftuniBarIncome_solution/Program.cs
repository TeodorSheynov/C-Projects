using System;
using System.Text.RegularExpressions;

namespace SoftuniBarIncome_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[%]([A-Z][a-z]+)[%](?:[^|$%.]*)[<](\w+)[>](?:[^|$%.]*)[|]([0-9]+)[|](?:[^|$%.0-9]*)((?:[0-9]+\.[0-9]+)|(?:[0-9]+))[$]";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
           
            decimal total = 0;
            decimal currentBill = 0;
            while (input!="end of shift")
            {
                Match order = regex.Match(input);
                if (regex.IsMatch(input))
                {
                    currentBill= int.Parse(order.Groups[3].ToString()) * decimal.Parse(order.Groups[4].ToString());
                    total += int.Parse(order.Groups[3].ToString()) * decimal.Parse(order.Groups[4].ToString());
                    Console.WriteLine($"{order.Groups[1]}: {order.Groups[2]} - {currentBill:f2}");
                }
               
                
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");

        }
    }
}
