using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Handson
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder b1 = new ChildPackage();
            Builder b2 = new Adultpackage();

            director.Construct(b1);
            Console.Write("Child ");
            Package p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Console.Write("\n Adult ");
            Package p2 = b2.GetResult();
            p2.Show();

            Console.ReadKey();
        }
    }
}
