using System;

namespace les3
{
    public class Program
    {
        static public int S(int n) //Deze kwam niet tijdens de les, maar was om recursief beter te snappen.
        {
            if (n == 1) // Base case
            {
                return 1;
            }
            else
            {
                return S(n - 1) + n;
            }
        }

        static public int Factorial(int n) //Deze kwam niet tijdens de les, maar was om Factorial beter te snappen.
                                           //This is a form of recursion! https://nl.wikipedia.org/wiki/Faculteit_(wiskunde)
        {
            if (n <= 1) // Base case
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1); //Make progress en Compound interest rule.
            }
        }

        static public int Sum(int n) //Hiervoor gebruiken we mod (rest, wat er overblijft) 
                                     //en div (hoevaak 10 bijvoorbeeld in 123 past, dat is 12 keer).
                                     //Laatste getal is met mod (bereken je met %).
                                     //De rest is div (bereken je met / en dan haal je de rest weg of wat er achter de komma staat weg)
        {
            if (n < 0) // Voor mingetallen.
            {
                return Sum(-n);
            }
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return Sum(n / 10) + n % 10;
            }
        }
        // Hallo -> ollah.
        static public string Reverse(string s) // Probeer niet hierin een console.writeline neerzet! Mag wel voor debuggen, maar niet in het tentamen!
        {
            if (s.Length == 0) // Hiermee hou je rekening voor een lege string.
            {
                return "";
            }
            else
            {
                return Reverse(s.Substring(1)) + s[0];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("S: " + S(5));
            Console.WriteLine("Factorial: " + Factorial(5));
            Console.WriteLine("Sum: " + Sum(123));
            Console.WriteLine("Sum: " + Sum(2525));
            Console.WriteLine("Reverse: " + Reverse("Hallo"));
            Console.WriteLine("Reverse: " + Reverse("Parterretrap"));
        }
    }
}
