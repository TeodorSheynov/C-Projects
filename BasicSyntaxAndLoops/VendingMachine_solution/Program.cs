using System;

namespace VendingMachine_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string go;
            double sum = 0;
            do
            {
                input = Console.ReadLine();
                if (input != "Start")
                {


                    switch (input)
                    {
                        case "0.1":
                            sum += 0.1;
                            break;
                        case "0.2":
                            sum += 0.2;
                            break;
                        case "0.5":
                            sum += 0.5;
                            break;
                        case "1":
                            sum += 1;
                            break;
                        case "2":
                            sum += 2;
                            break;
                        default:
                            Console.WriteLine($"Cannot accept {input}");
                            break;
                    }
                }

            } while (input != "Start");
            do
            {
                input = Console.ReadLine();
                if (input != "End")
                {


                    switch (input)
                    {

                        case "Nuts":
                             if (sum - 2 < 0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else { Console.WriteLine("Purchased nuts"); sum -= 2; }
                            break;
                        case "Water":
                             if (sum - 0.7 < 0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                Console.WriteLine("Purchased water");
                                sum -= 0.7;
                            }

                            break;
                        case "Crisps":
                             if (sum - 1.5 < 0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else { Console.WriteLine("Purchased crisps"); sum -= 1.5; }
                            break;
                        case "Soda":
                            if (sum - 0.8 < 0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else { Console.WriteLine("Purchased soda"); sum -= 0.8; }
                            break;
                        case "Coke":
                             if (sum - 1 < 0)
                            {

                                Console.WriteLine("Sorry, not enough money");
                            }
                            else { Console.WriteLine("Purchased coke"); sum -= 1.0; }
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }
                }
            } while (input!="End");
            
            Console.WriteLine($"Change: {sum.ToString("F")}");
        }
    }
}
