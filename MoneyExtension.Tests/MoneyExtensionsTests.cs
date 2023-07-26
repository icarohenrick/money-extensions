namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimlToInt()
    {
        decimal valor = 279.98M;
        int cents = valor.ToCents();

        Assert.AreEqual(27998, cents);
    }
}