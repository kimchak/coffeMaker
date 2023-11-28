using System;
namespace CoCoffee
{
    public class CoolWhip : CondimentWrapper
    {
        Beverage beverage;

        public CoolWhip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            double totalCost = beverage.Cost() + .12;
            return Math.Round(totalCost, 2);
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", coolwhip";
        }
    }
}

