using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AD
{
    [TestFixture]
    public partial class SortingTests
    {
        [Test, Combinatorial]
        public void Sort(
                    //[Values("InsertionSort", "MergeSort", "ShellSort")] string sorterName,
                    [Values("MergeSort")] string sorterName,
                    //[Values(0, 10, 300)] int n)
                    [Values(10, 300)] int n)
        {
            List<int> list = new List<int>();
            List<int> listCopy;
            Sorter sorter;
            System.Random random = new System.Random();

            // Arrange
            sorter = DSBuilder.CreateSorter(sorterName);
            Assert.IsNotNull(sorter != null);

            // Arrange
            for (int i = 0; i < n; i++)
            {
                list.Add(random.Next(0, 100000));
            }

            /*list.Add(78083);
            list.Add(1886);
            list.Add(53121);
            list.Add(8946);
            list.Add(61);
            list.Add(48931);
            list.Add(58121);
            list.Add(22519);
            list.Add(91682);
            list.Add(31820);*/

            listCopy = new List<int>(list);
            listCopy.Sort();

            // Act
            sorter.Sort(list);

            // Assert
            bool equal = list.SequenceEqual(listCopy);
            Assert.IsTrue(equal);
        }
    }
}