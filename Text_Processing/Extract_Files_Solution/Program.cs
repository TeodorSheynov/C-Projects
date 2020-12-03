using System;

namespace Extract_Files_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);
            int last = input.Length;
            string[] file = input[last - 1].Split(".", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
