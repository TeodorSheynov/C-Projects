using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordValidator_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            if (!PasswordValidRange(x))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!PasswordCharacters(x))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!PasswordValidNums(x))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (PasswordCharacters(x) && PasswordValidNums(x)&& PasswordValidRange(x))
            {
                Console.WriteLine("Password is valid");
            }

        }
        private static bool PasswordCharacters(string x)
        {
            List<char> y = x.ToList();
            bool valid=true;
            for (int i = 0; i < x.Length; i++)
            {
                if (((int)y[i] >= 48 && (int)y[i] <= 57) ||
                    ((int)y[i] >= 65 && (int)y[i] <= 90) ||
                    ((int)y[i] >= 97 && (int)y[i] <= 122))
                {
                    
                }
                else
                {
                    valid = false;
                }
                
                
            }
            if(valid)
            {
                return true;
            }
            else { return false; }
        }
        private static bool PasswordValidRange(string x)
        {
            if (x.Length < 6 || x.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool PasswordValidNums(string x)
        {
            List<char> y = x.ToList();
            int br = 0;
            for (int i = 0; i < x.Length; i++)
            {
                bool z = int.TryParse(y[i].ToString(), out int v);
                if (z)
                {
                    br++;
                }

            }
            if (br < 2)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}