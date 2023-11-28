using System;
namespace CoCoffee
{
	public class EspressoShot : CondimentWrapper
	{
        Beverage beverage;

		public EspressoShot(Beverage beverage)
		{
            this.beverage = (CondimentWrapper)beverage;
		}

        public override double Cost()
        {
            double totalCost = beverage.Cost() + 1;
            return Math.Round(totalCost, 2);
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", extra espresso shot";
        }
    }
}

