using System;

namespace MidExam_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double pricePerCaplsule;
            int days;
            int capsulesCount;
            double totalPrice = 0;
            double orderPrice;
            for (int i = 0; i < orders; i++)
            {
                pricePerCaplsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());
                orderPrice = (days * capsulesCount) * pricePerCaplsule;
                Console.WriteLine($"The price for the coffee is: ${orderPrice.ToString("F")}");
                totalPrice += orderPrice;
            }
            Console.WriteLine($"Total: ${totalPrice.ToString("F")}");
        }
    }
}
