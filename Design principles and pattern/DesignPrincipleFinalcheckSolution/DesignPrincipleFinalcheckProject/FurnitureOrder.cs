using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipleFinalcheckProject
{
    class FurnitureOrder : Order
    {
        channel _channel;
        productType _productType;
        public FurnitureOrder(channel channel, productType productType) : base(channel, productType.Furniture)
        {
            _channel = channel;
            _productType = productType;
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(_productType + " Order is placed through " + _channel + " channel");
        }
    }
}
