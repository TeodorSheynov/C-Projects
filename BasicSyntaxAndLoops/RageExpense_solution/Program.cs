using System;

namespace RageExpense_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = Convert.ToInt32(Console.ReadLine());
            double headsetPrice = Convert.ToDouble(Console.ReadLine());
            double mousePrice = Convert.ToDouble(Console.ReadLine());
            double keyboardPrice = Convert.ToDouble(Console.ReadLine());
            double displayPrice = Convert.ToDouble(Console.ReadLine());
            double headsetexpense = lostGames/2* headsetPrice;
            double mouseexpense = lostGames / 3 * mousePrice;
            double keyboardexpense = lostGames / 6 * keyboardPrice;
            double displayexpense = lostGames / 12 * displayPrice;
            double total = headsetexpense + mouseexpense + keyboardexpense + displayexpense;
            Console.WriteLine($"Rage expenses: {total.ToString("F")} lv.");
        }
    }
}
