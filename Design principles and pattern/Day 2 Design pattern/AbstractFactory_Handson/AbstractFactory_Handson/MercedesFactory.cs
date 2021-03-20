using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Handson
{
	public class MercedesFactory : Factory
	{
		public override Tire MakeTire()
		{
			return new MercedesTire();
		}
		public override HeadLight MakeHeadLight()
		{
			return new MercedesHeadLight();
		}
	}
}
