using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> race = new Dictionary<string, int>();
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < participants.Length; i++)
            {
                race.Add(participants[i], 0);
            }


            string input = Console.ReadLine();
            string patterName = @"([A-Za-z])";
            string patternDistance = @"(\d)";
            Regex regexName = new Regex(patterName);
            Regex regexDistance = new Regex(patternDistance);


            while (input != "end of race")
            {
                StringBuilder sbName = new StringBuilder();
                int distanceSum = 0;
                MatchCollection nameChars = regexName.Matches(input);
                MatchCollection distance = regexDistance.Matches(input);


                foreach (Match item in nameChars)
                {
                    sbName.Append(item.Groups[1]);
                }
                foreach (Match item in distance)
                {
                    distanceSum += int.Parse(item.Groups[1].ToString());
                }
                if (race.ContainsKey(sbName.ToString()))
                {
                    race[sbName.ToString()] += distanceSum;
                }
                input = Console.ReadLine();
            }
            int top3 = 0;
            string[] ending = new string[3] { "st", "nd", "rd" };
            foreach (var item in race.OrderByDescending(x=>x.Value))
            {
                
                Console.WriteLine($"{top3+1}{ending[top3]} place: {item.Key}");
                top3++;
                if (top3==3)
                {
                    break;
                }
            }
        }
    }
}
