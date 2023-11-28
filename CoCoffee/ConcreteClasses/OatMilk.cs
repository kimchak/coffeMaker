using System;
namespace CoCoffee
{
	public class OatMilk : CondimentWrapper
	{
		Beverage beverage;

		public OatMilk(Beverage beverage)
		{
			description = "Havermelk";
			this.beverage = beverage;
		}

		public override double Cost()
		{
			double totalCost = beverage.Cost() + .20;
            return Math.Round(totalCost, 2);
		}

        public override string getDescription()
        {
			return beverage.getDescription() + ", oatmilk";
        }
    }
}

