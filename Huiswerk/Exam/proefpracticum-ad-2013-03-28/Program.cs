using AD;
using System;

namespace proefpracticum_ad_2013_03_28
{
    class Program
    {
        public static void Op1()
        {
            Console.WriteLine(Opgave1.PrintLetters(3));
            Console.WriteLine(Opgave1.PrintLetters(0));

            Console.WriteLine(Opgave1.PrintLetters2(3, 5));
            Console.WriteLine(Opgave1.PrintLetters2(2, 0));
        }

        public static void Op2()
        {
            IBinarySearchTree<int> t = DSBuilder.CreateBinarySearchTreeProeftoets2013();

            // Act
            Console.WriteLine(t.GeefEenNaKleinsteElement());
        }

        static void Main(string[] args)
        {
            //Op1();
            Op2();
        }
    }
}
