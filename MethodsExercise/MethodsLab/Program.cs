using System;

namespace MethodsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = -5;
            
            string b = "-3.5";
            var x = Console.ReadLine();
            
         
            Console.WriteLine(SignOfNumber(y));//negative 
            Console.WriteLine(SignOfNumber(b));//negative double converted from string
            Console.WriteLine(SignOfNumber(x));// your num?
        }

       
        private static string SignOfNumber(int v)
        {

            int number = v;
            if (number < 0)
            {
                return $"The number {number} is negative.";
            }
            else if (number > 0)
            {
                return $"The number {number} is positive.";
            }
            else
            {
                return $"The number {number} is zero.";
            }
        }
        private static string SignOfNumber(string v)
        {
            int z;
            double y;
            bool x = Int32.TryParse(v, out z);
            bool t = Double.TryParse(v, out y);

            if (x)
            {
                if (z < 0)
                {
                    return $"The number {z} is negative.";
                }
                else if (z > 0)
                {
                    return $"The number {z} is positive.";
                }
                else
                {
                    return $"The number {z} is zero.";
                }
            }
            else if (t)
            {
                if (y < 0)
                {
                    return $"The number {y} is negative.";
                }
                else if (z > 0)
                {
                    return $"The number {y} is positive.";
                }
                else
                {
                    return $"The number {y} is zero.";
                }
            }else { return "There is no number"; }


        }
    }
}
