using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility_Handson
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest leaveRequest = new LeaveRequest();
            leaveRequest.Employee = "Dhanshri";
            leaveRequest.LeaveDays = 4;

            Supervisor supervisor = new Supervisor();
            supervisor.HandleRequest(leaveRequest);
            Console.ReadKey();
        }
    }
}
