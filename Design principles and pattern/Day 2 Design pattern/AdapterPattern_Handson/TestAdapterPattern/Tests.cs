using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern_Handson;

namespace TestAdapterPattern
{
    public class Tests
    {
        public void whenConvertingMPHToKMPH_thenSuccessfullyConverted()
        {
            IMovable bugattiVeyron = new BugattiVeyron();
            IMovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);

            assert.AreEquals(bugattiVeyronAdapter.getSpeed(), 431.30312, 0.00001);
        }
    }
}
