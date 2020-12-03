using System;
using System.Collections.Generic;
using System.Linq;

namespace Course_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (input[0] != "end")
            {
                if (!courses.ContainsKey(input[0]))
                {
                    courses.Add(input[0], new List<string>() { input[1] });
                }
                else
                {
                    courses[input[0]].Add(input[1]);
                }

                input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var course in courses.OrderByDescending(i=>i.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var item in course.Value.OrderBy(i=>i))
                {
                    Console.WriteLine($"-- {item}");
                }
            }

            
        }
    }
}
    

