using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Handson
{
	public abstract class HeadLight
	{
		protected string _headLightModel;

		public HeadLight(string headLightModel)
		{
			_headLightModel = headLightModel;
		}

		public string getHeadLightModel()
		{
			return _headLightModel;
		}
	}

	public class AudiHeadLight : HeadLight
	{
		public AudiHeadLight(): base("audi headlight")
		{
		}
	}

	public class MercedesHeadLight : HeadLight
	{
		public MercedesHeadLight():base("mercedes headlight")
		{
		}
	}
}

