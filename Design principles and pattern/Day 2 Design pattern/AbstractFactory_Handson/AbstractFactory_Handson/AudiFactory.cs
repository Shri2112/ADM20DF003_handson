using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Handson
{
	public class AudiFactory : Factory
	{
		public override Tire MakeTire()
		{
			return new AudiTire();
		}

		public override HeadLight MakeHeadLight()
		{
			return new AudiHeadLight();
		}
	}
}
