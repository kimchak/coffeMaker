using System;
namespace CoCoffee
{
	public abstract class Beverage
	{
		protected string description = "unknown beverage";
		public virtual string getDescription()
		{
			return description;
		}

        public abstract double Cost();
	}
}

