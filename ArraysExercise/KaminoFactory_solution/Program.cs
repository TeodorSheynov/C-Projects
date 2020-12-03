using System;
using System.Linq;

namespace KaminoFactory_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            bool success = Int32.TryParse(x, out int length);
           
            if (!success || length<=0)
            {
                return;
            }            
            string input = Console.ReadLine();
         

            int[] array = new int[length];
            int[] result = new int[length];
            int index = 0;
            int bestIndex = 0;
            int bestDNArow = 0;
            while (input!="Clone them!")
            {
                
                array =input.Split(new char[] { '!' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

                
                int startIndex =Array.IndexOf(array,1);
                if (startIndex>bestIndex)
                {
                    bestIndex = startIndex;
                    result = array;
                    index = bestDNArow;
                }
                else if (startIndex==bestIndex && array.Sum()>=result.Sum())
                {
                    bestIndex = startIndex;
                    result = array;
                    index = bestDNArow;
                    
                }
                else
                {
                    continue;
                }
                bestDNArow++;
                input = Console.ReadLine();

            }
            Console.Write("Best DNA sample {0} with sum: ", index);
            Console.Write(String.Join(" ", result.Sum()));
            Console.WriteLine(".");
            Console.WriteLine(String.Join(" ", result));

        }
    }
}
