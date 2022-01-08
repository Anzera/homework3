using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jakąś liczbę:");
            var number = GetNumber();
            EvenOddNumber(number);
        }

        private static int GetNumber()
        {
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("\nWprowadzono nieprawidłowe dane! Wpisz liczbę");
                    continue;
                }
                return number;
            }
        }

        private static void EvenOddNumber(int number)
        {
            if(number % 2 == 0)
                Console.WriteLine($"\nLiczba {number} jest parzysta");
            else
                Console.WriteLine($"\nLiczba {number} jest nieparzysta");
        }
    }
}
