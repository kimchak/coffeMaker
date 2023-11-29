namespace CoCoffee

{
    public static class Helpers
	{

        public static void printOut(CondimentWrapper beverage)
        {
            Console.WriteLine(
            beverage.getDescription() + " : " + (beverage.Cost())
            );
        }
    }
}

