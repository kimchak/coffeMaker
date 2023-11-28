using System;
namespace CoCoffee
{
	public class TarRoast : Beverage
	{
		public TarRoast()
		{
			description = "Tar-dark roast";
		}

        public override double Cost()
        {
			return .90;
        }
    }
}

