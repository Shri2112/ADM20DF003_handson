using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility_Handson
{
    class Supervisor : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler;

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays > 3)
            {
                this.nextHandler = new ProjectManager();
                this.nextHandler.HandleRequest(leaveRequest);
            }
            else
            {
                Console.WriteLine("Approverd by Suprevisor");
            }

        }

    }
}
