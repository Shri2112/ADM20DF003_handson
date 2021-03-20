using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Handson
{
    public class BugattiVeyron:IMovable
    {
        public double getPrice()
        {
            return 10000;
        }
    }
}
