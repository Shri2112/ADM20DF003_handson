using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Handson
{
    public class FactoryMaker
    {
		public static Factory getFactory(string factoryName)
		{
			if (factoryName.Equals("audi"))
				return new AudiFactory();
			else if (factoryName.Equals("mercedes"))
				return new MercedesFactory();
			else
				return null;
		}
	}
}
