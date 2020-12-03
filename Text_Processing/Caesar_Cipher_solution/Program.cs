using System;

namespace Caesar_Cipher_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            foreach (var item in x.ToCharArray())
            {
                int z = (char)item + 3;
                Console.Write((char)z);
            }
        }
    }
}
