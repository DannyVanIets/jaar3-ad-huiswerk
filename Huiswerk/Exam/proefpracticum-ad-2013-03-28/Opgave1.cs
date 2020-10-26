using System;
using System.Collections.Generic;
using System.Text;

namespace proefpracticum_ad_2013_03_28
{
    public class Opgave1
    {
        public static string PrintLetters(int n)
        {
            string Print = "";
            Print += RecursivePrint("A", n);
            Print += RecursivePrint("Z", n);
            return Print;
        }

        public static string PrintLetters2(int p, int q)
        {
            string Print = "";
            Print += RecursivePrint("A", p);
            Print += RecursivePrint("Z", q);
            return Print;
        }

        public static string RecursivePrint(string letter, int n)
        {
            if (n > 0)
            {
                return RecursivePrint(letter, n - 1) + letter;
            }
            return "";
        }
    }
}
