namespace CoCoffee.Tests;

public class CoCoffeUnitTests
{
    [Fact]
    public void blackCoffeShouldReturnCorrentPriceAndName()
    {
        //Arrange
        var tarRoast = new TarRoast();
        Assert.Equal(0.9, tarRoast.Cost());
        Assert.Equal("Tar-dark roast", tarRoast.getDescription());
    }

    [Fact]
    public void complexCoffeWithCondimentsReturnsCorrectPriceAndName()
    {
        //Arrange
        Beverage beverage1 = new TarRoast();
        CondimentWrapper beverage2 = new OatMilk(beverage1);
        CondimentWrapper beverage3 = new EspressoShot(beverage2);
        CondimentWrapper beverage4 = new CoolWhip(beverage3);
        CondimentWrapper beverage5 = new OatMilk(beverage4);

        Assert.Equal(2.42,beverage5.Cost());
        Assert.Equal("Tar-dark roast, oatmilk, extra espresso shot, coolwhip, oatmilk", beverage5.getDescription());
    }
}
