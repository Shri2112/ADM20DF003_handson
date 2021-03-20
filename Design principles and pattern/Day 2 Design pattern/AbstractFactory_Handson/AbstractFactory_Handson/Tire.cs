using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Handson
{
	public abstract class Tire
	{
		protected string _tireModel;
	
	public Tire(string tireModel)
		{
			_tireModel = tireModel;
		}

		public string getTireModel()
		{
			return _tireModel;
		}
	}

	public class AudiTire : Tire
	{
		public AudiTire(): base("audi tire")
		{
		}

	}
	public class MercedesTire : Tire
	{
		public MercedesTire(): base("mercedes tire")
		{
		}
	}
}

