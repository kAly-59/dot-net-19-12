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
}
