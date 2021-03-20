using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipleFinalcheckProject
{
    abstract class Order
    {
        public Order(channel channel,productType productType)
        {
            this.Channel = channel;
            this.productType = productType;
        }
        public channel Channel { get; set; }
        public productType productType { get; set; }
        public abstract void processOrder();
    }
}
