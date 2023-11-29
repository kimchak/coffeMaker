// See https://aka.ms/new-console-template for more information
using CoCoffee;

Beverage beverage1 = new TarRoast();
Console.WriteLine(beverage1.getDescription() +" : " +beverage1.Cost());

CondimentWrapper beverage2 = new OatMilk(beverage1);
Console.WriteLine(beverage2.getDescription() + " : " + beverage2.Cost());

CondimentWrapper beverage3 = new EspressoShot(beverage2);
Console.WriteLine(beverage3.getDescription() + " : " + beverage3.Cost());

CondimentWrapper beverage4 = new CoolWhip(beverage3);
Console.WriteLine(beverage4.getDescription() + " : " + beverage4.Cost());
//printOut(beverage4);
//Console.WriteLine(beverage3.getDescription() +" : " + beverage3.Cost());

CondimentWrapper beverage5 = new OatMilk(beverage4);
Helpers.printOut(beverage5);
