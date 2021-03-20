using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            DBConn firstCall = DBConn.GetInstance();
            firstCall.CallerMethod("This is first call..!!");
            DBConn SecondCall = DBConn.GetInstance();
            SecondCall.CallerMethod("This is second call..!!");
            DBConn thirdCall = DBConn.GetInstance();
            thirdCall.CallerMethod("This is third call..!!");
            Console.ReadLine();
        }
    }
}
