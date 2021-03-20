using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipleFinalcheckProject
{
    class FactoryDesign : Factory
    {
        Order order;

        public override void ElectronicOrder(channel channel)
        {
            order = new ElectronicOrder(channel, productType.Electronic);
        }

        public override void FurnitureOrder(channel channel)
        {
            order = new FurnitureOrder(channel, productType.Furniture);
        }

        public override void ToysOrder(channel channel)
        {
            order = new ToysOrder(channel, productType.Toys);
        }
    }
}
