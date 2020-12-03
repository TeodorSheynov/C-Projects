using System;

namespace PadawanEquipment_solution
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            double money = Convert.ToDouble(Console.ReadLine());
            int students = Convert.ToInt32(Console.ReadLine());
            double lightsabers = Convert.ToDouble(Console.ReadLine());
            double robes = Convert.ToDouble(Console.ReadLine());
            double belts = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            int beltsfree = 0;
            double sum2 = 0;
            double sum3 = 0;
                double total = 0;
            double percentStud = Convert.ToDouble(students) / 10;
            double ceiledstud = Math.Ceiling(percentStud);
            if (students>=6)
            {
                beltsfree = students / 6;
                sum2 = belts * (students - beltsfree);

            }
            else { sum2 = belts * students; }

            sum3 = robes * students;

            sum = lightsabers * (ceiledstud + students);
            
            total = sum + sum3 + sum2;
            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total.ToString("F")}lv.");
            }
            else
            {
                total = total - money;
                Console.WriteLine($"Ivan Cho will need {total.ToString("F")}lv more.");
            }
        }
    }
}
