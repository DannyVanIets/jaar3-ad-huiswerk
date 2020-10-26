using NUnit.Framework;
using proefpracticum_ad_2013_03_28;

namespace AD
{
    [TestFixture]
    public class Op2BSTTests
    {
        [TestCase(2)]
        public void EenNaKleinsteElementTest(int expected)
        {
            int actual;

            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeProeftoets2013();

            // Act
            actual = tree.GeefEenNaKleinsteElement();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3)]
        public void EenNaKleinsteElementTestZonder1(int expected)
        {
            int actual;

            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeProeftoets2013Zonder1();

            // Act
            actual = tree.GeefEenNaKleinsteElement();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}