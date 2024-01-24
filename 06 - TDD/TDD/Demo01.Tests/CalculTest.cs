using Demo01.Bibliotheque;

namespace Demo01.Tests;

[TestClass]
public class CalculTest
{
    [TestMethod]
    public void WhenAddition_10_30_Then_40()
    {
        // Arrange 
        var calcul = new Calcul();

        // Act
        var result = calcul.Addition(10, 30);

        // Assert
        Assert.AreEqual(40, result);
    }

    [TestMethod]
    public void WhenDivision_30_10_Then_3()
    {
        // Arrange 
        var calcul = new Calcul();

        // Act
        double result = calcul.Division(30, 10);

        // Assert
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void WhenDivision_1_0_Then_DivideByZeroException()
    {
        // Arrange
        var calcul = new Calcul();

        // Act et Assert
        Assert.ThrowsException<DivideByZeroException>(() => calcul.Division(1, 0));
    }
}
