using System;

namespace Login_solution
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            
            
            int br = 0;
            string password;
            do
            {
                password = Console.ReadLine();
                if (Reverse(username) == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                br++; 
                if (br==4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    br = 0;
                    break;
                }
                if (Reverse(username) != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                
               
            } while (Reverse(username)!=password);

        }
    }
}
