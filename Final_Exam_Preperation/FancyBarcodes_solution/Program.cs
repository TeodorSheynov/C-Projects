using System;
using System.Text;
using System.Text.RegularExpressions;

namespace FancyBarcodes_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string barcodePattern= @"(?:@#+)([A-Z][A-Za-z0-9]{4,}[A-Z])(?:@#+)";
            string numberPattern = @"\d";
            StringBuilder numberBarcode = new StringBuilder();
            
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string barcode = Console.ReadLine();
                Regex regexBarcode = new Regex(barcodePattern);
                Regex regexNumbers = new Regex(numberPattern);
                MatchCollection numberMatches= regexNumbers.Matches(barcode);

                if (regexBarcode.IsMatch(barcode))
                {
                    if (regexNumbers.IsMatch(barcode))
                    {
                        foreach (Match item in numberMatches)
                        {
                            numberBarcode.Append(item.Value);
                        }
                        Console.WriteLine($"Product group: {numberBarcode}");
                        numberBarcode.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }else
                {
                    Console.WriteLine("Invalid barcode");
                }
                    
            }
           
        }
    }
}
