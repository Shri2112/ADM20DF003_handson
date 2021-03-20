using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Handson
{
    abstract class Builder
    {
        public abstract void Sweets();
        public abstract void Savory();
        public abstract Package GetResult();
    }
}
