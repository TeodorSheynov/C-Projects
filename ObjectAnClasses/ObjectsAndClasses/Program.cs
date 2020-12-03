using System;

namespace ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMessage = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberMessage; i++)
            {
                AdvertisementMessage();
            }
        }

        private static void AdvertisementMessage()
        {
            Random rnd = new Random();
            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of itscategory.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            string[] events = new string[]
            {
                " Now I feel good.",
                " I have succeeded with this product.",
                " Makes miracles. I am happy of the results!",
                " I cannot believe but now I feel awesome.",
                " Try it yourself, I am very satisfied.",
                " I feel great!"
            };
            string[] authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            string[] cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Console.WriteLine($"{phrases[rnd.Next(0,phrases.Length)]} " +
                $"{events[rnd.Next(0,events.Length)]} " +
                $"{authors[rnd.Next(0,authors.Length)]} - {cities[rnd.Next(0,cities.Length)]}.");
        }


    }
}


