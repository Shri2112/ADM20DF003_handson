using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_Handson
{
    public class ShapeMaker
    {
        private IShape circle;
        private IShape rectangle;
        private IShape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }
        public void drawCircle()
        {
            circle.Draw();
        }
        public void drawRectangle()
        {
            rectangle.Draw();
        }
        public void drawSquare()
        {
            square.Draw();
        }
    }
}
