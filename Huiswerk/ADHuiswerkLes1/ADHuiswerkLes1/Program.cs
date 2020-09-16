using System;
using System.Diagnostics;

namespace ADHuiswerkLes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int sum = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Fragment 7
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n * n; j++)
                    for (int k = 0; k < j; k++)
                        sum++;

            stopwatch.Stop();
            Console.WriteLine("Sum: " + sum.ToString() + ". Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
