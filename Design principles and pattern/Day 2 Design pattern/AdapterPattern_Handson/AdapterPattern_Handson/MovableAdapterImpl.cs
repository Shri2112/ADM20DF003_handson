using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Handson
{
    class MovableAdapterImpl : IMovableAdapter
    {
        private IMovable _luxuryCars;

        public MovableAdapterImpl(IMovable luxuryCars)
        {
            _luxuryCars = luxuryCars;
        }
        public double getPrice()
        {
            return convertUSDToEuro(_luxuryCars.getPrice());
        }
        private double convertUSDToEuro(double USD)
        {
            return USD * 0.84;
        }

    }
}
