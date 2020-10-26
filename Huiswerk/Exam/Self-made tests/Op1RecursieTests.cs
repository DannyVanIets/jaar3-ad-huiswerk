using NUnit.Framework;
using proefpracticum_ad_2013_03_28;

namespace AD
{
    [TestFixture]
    public class Op1RecursieTests
    {
        [TestCase(3, "AAAZZZ")]
        [TestCase(0, "")]
        public void PrintLettersTest(int n, string expected)
        {
            string actual;

            // Arrange

            // Act
            actual = Opgave1.PrintLetters(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 5, "AAAZZZZZ")]
        [TestCase(2, 0, "AA")]
        public void PrintLetters2Test(int p, int q, string expected)
        {
            string actual;

            // Arrange

            // Act
            actual = Opgave1.PrintLetters2(p, q);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}