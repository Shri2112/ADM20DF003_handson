using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Handson
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.DoSomeClientJob();
            Console.ReadLine();
        }
    }
}
