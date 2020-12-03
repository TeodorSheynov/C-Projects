using System;
using System.Linq;

namespace MidExam_Fundamentals_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = new int[] { };
            priceRatings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string value = Console.ReadLine();
            string type = Console.ReadLine();
            int sumLeft = 0;
            int sumRight = 0;

            switch (type)
            {
                case "positive":
                   
                    if (value=="expensive")
                    {
                        ExpensiveValue(priceRatings, entryPoint);
                    }
                    if (value == "cheap")
                    {
                        CheapValue(priceRatings, entryPoint);
                    }
                    break;
                case "negative":
                    if (value == "expensive")
                    {
                        ExpensiveValue(priceRatings, entryPoint);
                    }
                    if (value == "cheap")
                    {
                        CheapValue(priceRatings, entryPoint);
                        
                    }
                    break;
                case "all":
                    if (value == "expensive")
                    {
                        for (int i = 0; i < entryPoint; i++)
                        {
                            if (priceRatings[i] > priceRatings[entryPoint])
                            {
                                sumLeft += priceRatings[i];
                            }
                        }
                        for (int i = entryPoint + 1; i < priceRatings.Length; i++)
                        {
                            if (priceRatings[i] > priceRatings[entryPoint])
                            {
                                sumRight += priceRatings[i];
                            }
                        }
                        if (sumLeft >= sumRight)
                        {
                            Console.WriteLine($"Left - {sumLeft}");
                        }
                        else
                        {
                            Console.WriteLine($"Right - {sumRight}");
                        }
                    }
                    if (value == "cheap")
                    {
                        for (int i = 0; i < entryPoint ; i++)
                        {
                            if (priceRatings[i] < priceRatings[entryPoint])
                            {
                                sumLeft += priceRatings[i];
                            }
                        }
                        for (int i = entryPoint + 1; i < priceRatings.Length; i++)
                        {
                            if (priceRatings[i] < priceRatings[entryPoint])
                            {
                                sumRight += priceRatings[i];
                            }
                        }
                        if (sumLeft >= sumRight)
                        {
                            Console.WriteLine($"Left - {sumLeft}");
                        }
                        else
                        {
                            Console.WriteLine($"Right - {sumRight}");
                        }
                    }
                    break;

                default:
                    break;
            }
            
        }

        private static void CheapValue(int[] priceRatings, int entryPoint)
        {
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < entryPoint; i++)
            {
                if (priceRatings[i] < 0 && priceRatings[i] < priceRatings[entryPoint])
                {
                    sumLeft += priceRatings[i];
                }
            }
            for (int i = entryPoint + 1; i < priceRatings.Length; i++)
            {
                if (priceRatings[i] < 0 && priceRatings[i] < priceRatings[entryPoint])
                {
                    sumRight += priceRatings[i];
                }
            }
            if (sumLeft >= sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
            else
            {
                Console.WriteLine($"Right - {sumRight}");
            }
        }

        private static void ExpensiveValue(int[] priceRatings, int entry)
        {
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < entry; i++)
            {
                if (priceRatings[i] > 0 && priceRatings[i] > priceRatings[entry])
                {
                    sumLeft += priceRatings[i];
                }
            }
            for (int i = entry + 1; i < priceRatings.Length; i++)
            {
                if (priceRatings[i] > 0 && priceRatings[i] > priceRatings[entry])
                {
                    sumRight += priceRatings[i];
                }
            }
            if (sumLeft >= sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
            else
            {
                Console.WriteLine($"Right - {sumRight}");
            }

        }
    }
}
