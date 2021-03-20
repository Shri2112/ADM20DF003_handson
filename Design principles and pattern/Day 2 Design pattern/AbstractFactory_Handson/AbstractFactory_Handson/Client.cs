using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Handson
{
    public class Client
    {
		public void DoSomeClientJob()
		{
			Tire tire = FactoryMaker.getFactory("audi").MakeTire();
			Console.WriteLine(tire.getTireModel());
			HeadLight light = FactoryMaker.getFactory("audi").MakeHeadLight();
			Console.WriteLine(light.getHeadLightModel());
		}
	}
}
