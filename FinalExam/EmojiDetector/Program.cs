using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string emojiPatern = @"(:{2}|\*{2})([A-Z][a-z]{2,})\1";
            string numbers = @"\d";
            Regex emojis = new Regex(emojiPatern);
            Regex coolnes = new Regex(numbers);
            MatchCollection emojisMatch = emojis.Matches(input);
            MatchCollection numbersMatch = coolnes.Matches(input);
            BigInteger coolTreshold = 1;
            List<string> coolEmoji = new List<string>();
            foreach (Match item in numbersMatch)
            {
                coolTreshold *= int.Parse(item.Value);
            }
            foreach (Match item in emojisMatch)
            {
                char[] charemoji = item.Groups[2].Value.ToCharArray();
                int sumofchars = 0;
                for (int i = 0; i < charemoji.Length; i++)
                {
                    sumofchars += (int)charemoji[i];
                }
                if (sumofchars>coolTreshold)
                {
                    coolEmoji.Add(item.Groups[0].ToString());
                }
            }
            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{emojisMatch.Count} emojis found in the text. The cool ones are:");
            foreach (var item in coolEmoji)
            {
                Console.WriteLine(item);
            }
        }
    }
}
