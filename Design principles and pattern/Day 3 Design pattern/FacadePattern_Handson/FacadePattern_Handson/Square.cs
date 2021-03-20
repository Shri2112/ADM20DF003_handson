using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_Handson
{
    public class Square:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }
}
