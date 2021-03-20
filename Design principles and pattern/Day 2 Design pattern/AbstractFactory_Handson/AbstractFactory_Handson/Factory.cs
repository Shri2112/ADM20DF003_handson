using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Handson
{
	public abstract class Factory
	{
		public abstract Tire MakeTire();

		public abstract HeadLight MakeHeadLight();
	}
}

