using System;

namespace Vacation_solution
{
    class Program
    {
        static void Students(int _Number,string day)
        {
            double total_price=0;
            
            switch (day)
            {
                case "Friday":
                    total_price=_Number*8.45;
                    break;
                case "Saturday":
                    total_price = _Number *9.80;
                    break;
                case "Sunday":
                    total_price = _Number * 10.46;
                    break;
                default:
                   
                    break;
            }

            if (_Number>=30)
            {
               total_price = total_price - (total_price * 15 / 100);
            }
            Console.WriteLine($"Total price: {total_price.ToString("F")}");
            
            
        }
        static void Business(int _Number, string day)
        {
            double total_price = 0;

            switch (day)
            {
                case "Friday":
                    if (_Number >= 100)
                    {
                        total_price = (_Number - 10) * 10.90;
                    }
                    else { total_price = _Number * 10.90; }

                    break;
                case "Saturday":
                    if (_Number >= 100)
                    {
                        total_price = (_Number - 10) * 15.60;
                    }
                    else { total_price = _Number * 15.60; }

                    break;
                case "Sunday":
                    if (_Number >= 100)
                    {
                        total_price = (_Number - 10) * 16;
                    }
                    else { total_price = _Number * 16; }

                    break;
                default:

                    break;
            }
            Console.WriteLine($"Total price: {total_price.ToString("F")}");


        }
        static void Regular(int _Number, string day)
        {
            double total_price = 0;

            switch (day)
            {
                case "Friday":
                    total_price = _Number * 15;
                    break;
                case "Saturday":
                    total_price = _Number * 20;
                    break;
                case "Sunday":
                    total_price = _Number * 22.50;
                    break;
                default:

                    break;
            }

            if (_Number >= 10 && _Number <=20)
            {
                total_price = total_price - (total_price * 5 / 100);
               
            }
            Console.WriteLine($"Total price: {total_price.ToString("F")}");


        }
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string type = Console.ReadLine();
            string date = Console.ReadLine();
            
            if(type=="Students")
            {
                Students(number, date);
            }
            if(type=="Business")
            {
                Business(number, date);
            }
            if(type=="Regular")
            {
                Regular(number, date);
            }
        }
    }
}
