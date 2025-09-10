using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MockTestsHomeWork
{
    [TestClass]
    public class DataRowCalcTest
    {
        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(-5, 5, 0)]
        [DataRow(0, 0, 0)]
        public void SumTest(int a, int b, int expected)
        {
            // Arrange
            DataRowCalc calc = new DataRowCalc();

            // Act
            int result = calc.Sum(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}