using Demo01.Bibliotheque;

namespace Demo01.TestsNUnit;


[TestFixture]
public class CalculTest
{
    [Test]
    public void WhenAddition_10_30_Then_40()
    {
        // Arrange 
        var calcul = new Calcul();

        // Act
        var result = calcul.Addition(10, 30);

        // Assert
        //Assert.AreEqual(40, result);
        Assert.That(result, Is.EqualTo(40));
    }

    [Test]
    public void WhenDivision_30_10_Then_3()
    {
        // Arrange 
        var calcul = new Calcul();

        // Act
        double result = calcul.Division(30, 10);

        // Assert
        //Assert.AreEqual(3, result);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void WhenDivision_1_0_Then_DivideByZeroException()
    {
        // Arrange
        var calcul = new Calcul();

        // Act et Assert
        Assert.Throws<DivideByZeroException>(() => calcul.Division(1, 0));
    }
}
