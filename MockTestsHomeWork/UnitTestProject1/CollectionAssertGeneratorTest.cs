using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MockTestsHomeWork
{
    [TestClass]
    public class CollectionAssertGeneratorTest
    {
        [TestMethod]
        public void GetSquareNumbers_ReturnsExpectedCollection()
        {
            // Arrange
            CollectionAssertNumberGenerator generator = new CollectionAssertNumberGenerator();
            int[] expected = { 1, 4, 9, 16 };

            // Act
            List<int> result = new List<int>();
            foreach (int number in generator.GetSquareNumbers(4))
            {
                result.Add(number);
            }

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}