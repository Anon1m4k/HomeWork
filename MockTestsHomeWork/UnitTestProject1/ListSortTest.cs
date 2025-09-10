using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MockTestsHomeWork
{
    [TestClass]
    public class ListSortTest
    {
        [TestMethod]
        public void GetSortListTest()
        {
            // Arrange
            ListSort sort = new ListSort();
            List<int> input = new List<int> {3, 1, 2};
            List<int> expected = new List<int> {1, 2, 3};

            // Act
            List<int> result = sort.GetSortList(input);

            // Assert
            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}