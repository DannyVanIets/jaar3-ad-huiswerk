﻿namespace AD
{
    public class Opgave2
    {
        static long calls = 0;

        private static long FibonacciRecursiveInternal(int n)
        {
            calls++;
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibonacciRecursiveInternal(n - 1) + FibonacciRecursiveInternal(n - 2);
            }
        }

        public static long FibonacciRecursive(int n)
        {
            calls = 0;
            return FibonacciRecursiveInternal(n);
        }

        private static long FibonacciIterativeInternal(int n)
        {
            int previousNumber = 0;
            int currentNumber = 1;
            int result = 1;

            for(int i = 1; i < n; i++, calls++)
            {
                result = previousNumber + currentNumber;
                previousNumber = currentNumber;
                currentNumber = result;
            }
            return result;
        }

        public static long FibonacciIterative(int n)
        {
            calls = 0;
            return FibonacciIterativeInternal(n);
        }

        public static void Run()
        {
            int MAX = 35;

            System.Console.WriteLine("Recursief:");
            for (int n = 1; n <= MAX; n++)
            {
                System.Console.WriteLine("          Fibonacci({0,2}) = {1,8} ({2,9} calls)", n, FibonacciRecursive(n), calls);
            }
            System.Console.WriteLine("Iteratief:");
            for (int n = 1; n <= MAX; n++)
            {
                System.Console.WriteLine("          Fibonacci({0,2}) = {1,8} ({2,9} loops)", n, FibonacciIterative(n), calls);
            }
        }
    }
}