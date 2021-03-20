using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Handson
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMovable bugattiVeyron = new BugattiVeyron();
            IMovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);

            Console.WriteLine("Price of car = " + bugattiVeyronAdapter.getPrice()+"Euro");
            Console.ReadKey();
        }
    }
}
