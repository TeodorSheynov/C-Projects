using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (grades.ContainsKey(name))
                {
                    grades[name].Add(grade);
                }
                else
                {
                    grades.Add(name, new List<double>() { grade });
                }  
            }
           
            foreach (var item in grades.OrderByDescending(x=>x.Value.Average()))
            {
                if (item.Value.Average()>= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average()}");
                }
                    
            }
        }
    }
}
