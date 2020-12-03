using System;
using System.Linq;

namespace Condesed
{
    class Program
    {
        static void Main(string[] args)
        {
            var temps = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = temps.Select(int.Parse).ToArray();

            int[] condensed;

            do

            {
                condensed = new int[arr.Length - 1];

                for (int i = 0; i < arr.Length - 1; i++)

                {
                    condensed[i] = arr[i] + arr[i + 1];
                    arr[i] = condensed[i];

                }
                Array.Resize(ref arr, condensed.Length);

            } while (condensed.Length != 1);
            Console.WriteLine(arr[0]);
        }
    }
}
