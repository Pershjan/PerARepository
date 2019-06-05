using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            var sumtotal = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text.ToUpper() ?? string.Empty)
                {
                    sumtotal++;
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        float detSkjer = ((float)counts[i] * 100) / sumtotal;
                        var character = (char)i;
                        Console.WriteLine(character + " - " + $"{detSkjer/100,7:P}");
                    }
                }
                Console.WriteLine("Total mengde siffer: " + sumtotal);
            }
        }
    }
}
