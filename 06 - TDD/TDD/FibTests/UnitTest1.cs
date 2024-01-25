using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

[TestClass]
public class FibTests
{
    [TestMethod]
    public void TestFibSeriesWithRangeOne()
    {
        // Arrange
        var fib = new Fib(1);

        // Act
        var result = fib.GetFibSeries();

        // Assert
        Assert.IsNotNull(result);
        CollectionAssert.AreEqual(new List<int> { 0 }, result);
    }

    [TestMethod]
    public void TestFibSeriesWithRangeSix()
    {
        // Arrange
        var fib = new Fib(6);

        // Act
        var result = fib.GetFibSeries();

        // Assert
        Assert.IsTrue(result.Contains(3));
        Assert.AreEqual(6, result.Count);
        Assert.IsFalse(result.Contains(4));
        CollectionAssert.AreEqual(new List<int> { 0, 1, 1, 2, 3, 5 }, result);
        CollectionAssert.AreEqual(result.OrderBy(i => i).ToList(), result);
    }

    public class Fib
    {
        private int _range;

        public Fib(int r)
        {
            _range = r;
        }

        public List<int> GetFibSeries()
        {
            List<int> result = new List<int>();
            int a = 0, b = 1, c = 0;
            if (_range == 1)
            {
                result.Add(0);
                return result;
            }
            result.Add(0);
            result.Add(1);
            for (int i = 2; i < _range; i++)
            {
                c = a + b;
                result.Add(c);
                a = b;
                b = c;
            }
            return result;
        }
    }
}
