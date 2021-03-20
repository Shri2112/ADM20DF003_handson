using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Handson
{
    class Adultpackage : Builder
    {
        Package package = new Package();
        public override Package GetResult()
        {
            return package;
        }

        public override void Savory()
        {
            package.Add("2 savaries");
        }

        public override void Sweets()
        {
            package.Add("2 sweets");
        }
    }
}
