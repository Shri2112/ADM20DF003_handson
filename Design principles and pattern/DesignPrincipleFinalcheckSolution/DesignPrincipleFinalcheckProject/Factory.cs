using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipleFinalcheckProject
{
    abstract class Factory
    {
        public abstract void ElectronicOrder(channel channel);
        public abstract void ToysOrder(channel channel);
        public abstract void FurnitureOrder(channel channel);
    }
}
