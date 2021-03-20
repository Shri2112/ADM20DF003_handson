using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipleFinalcheckProject
{
    class ToysOrder : Order
    {
        channel _channel;
        productType _productType;
        public ToysOrder(channel channel,productType productType):base(channel, productType.Toys)
        {
            _channel = channel;
            _productType = productType;
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(_productType+" Order is placed through "+ _channel + " channel");
        }
    }
}
