using System;

namespace BeerkKegs_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            double kegVolume = 0;
            double kegVolumeMax = 0;
            string kegName="";
            int lines = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                
                string model = Console.ReadLine();
                double radius = Convert.ToDouble(Console.ReadLine());
                int height = Convert.ToInt32(Console.ReadLine());
                kegVolume = 3.14 * (Math.Pow(radius, 2) * height);
                if (kegVolume > kegVolumeMax)
                {
                    kegVolumeMax = kegVolume;
                    kegName = model;
                }
            }
            Console.WriteLine(kegName);
           

        }
    }
}
