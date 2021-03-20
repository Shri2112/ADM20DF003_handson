using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipleFinalcheckProject
{
    class ClientOrder
    {
        Factory factory;
        public ClientOrder(Factory factory)
        {
            this.factory = factory;
        }
        public  void ElectronicOrder(channel channel)
        {
            factory.ElectronicOrder(channel);
        }

        public  void FurnitureOrder(channel channel)
        {
            factory.FurnitureOrder(channel);
        }

        public  void ToysOrder(channel channel)
        {
            factory.ToysOrder(channel);
        }

    }
}
