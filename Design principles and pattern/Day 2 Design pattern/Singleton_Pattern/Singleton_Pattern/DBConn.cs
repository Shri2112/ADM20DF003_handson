using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public sealed class DBConn
    {
        private static DBConn instance = null;
        private static int counter = 0;
        private static readonly object obj=new object();
        public static DBConn obj1 = new DBConn();

        public static DBConn GetInstance()
        {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = obj1;
                        }
                    }
                }
                return instance;
        }
        private DBConn()
        {
            counter++;
            Console.WriteLine("Counter value is:" + counter.ToString());
        }
        public void CallerMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
