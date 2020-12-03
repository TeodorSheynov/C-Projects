using System;
using System.Linq;
using System.Collections.Generic;

namespace VowelsCount_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToUpper();
            Console.WriteLine(Vowels(text));
        }

        private static int Vowels(string text)
        {
            List<char> x = text.ToList();
            int br=0;
            for (int i = 0; i < text.Length; i++)
            {
                switch (x[i])
                {
                    case 'A': br++;
                            break;
                    case 'E': br++;
                        break;
                    case 'I': br++;
                        break;
                    case 'O': br++;
                        break;
                    case 'U': br++;
                        break;
                    default:
                        break;
                }
            }
            return br;
        }
    }

}
