using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility_Handson
{
    class HR : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler;

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            Console.WriteLine("Approverd by HR");
        }

    }
}
