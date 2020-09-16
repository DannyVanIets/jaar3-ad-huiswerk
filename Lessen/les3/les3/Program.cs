using System;

namespace les3
{
    public class Program
    {
        static public int Sum(int n) //Hiervoor gebruiken we mod en div. Laatste getal is met mod. De rest is div.
        {
            if(n < 0) // Voor mingetallen.
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
            Console.WriteLine(Sum(123));
            Console.WriteLine(Sum(2525));
            Console.WriteLine(Reverse("Hallo"));
            Console.WriteLine(Reverse("Hallo"));
        }
    }
}
