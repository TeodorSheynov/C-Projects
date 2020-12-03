using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayRotation_solution
{
    class Program
    {
        static int[] rotLeft(int[] a, int d)
        {

            Queue<int> queue = new Queue<int>(a);
            Stack<int> stack = new Stack<int>();

            while (d > 0)
            {
                stack.Push(queue.Dequeue());
                queue.Enqueue(stack.Pop());
                d--;
            }

            return queue.ToArray();
        }
        static void Main(string[] args)
        {
            int[] x = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            foreach (var item in rotLeft(x,n))
            {
                Console.Write($"{item} ");
            }
            
        }
    }
}
