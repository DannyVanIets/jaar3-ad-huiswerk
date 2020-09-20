﻿using System;

namespace AD
{
    public class Opgave3
    {
        public static int OmEnOm(int n)
        {
            if (n < 0)
            {
                throw new OmEnOmNegativeValueException();
            }
            else if (n == 1 || n == 0)
            {
                return n;
            }
            else
            {
                return OmEnOm(n - 2) + n;
            }
        }
        public static void Run()
        {
            int MAX = 20;

            for (int n = 0; n < MAX; n++)
            {
                Console.WriteLine("          OmEnOm({0,2}) = {1,3}", n, OmEnOm(n));
            }
        }
    }

    public class OmEnOmNegativeValueException : Exception
    {
    }
}
