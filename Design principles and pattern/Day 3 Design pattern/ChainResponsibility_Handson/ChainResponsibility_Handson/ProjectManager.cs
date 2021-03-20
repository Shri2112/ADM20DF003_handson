using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility_Handson
{
    class ProjectManager : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler;

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays >5)
            {
                this.nextHandler = new HR();
                this.nextHandler.HandleRequest(leaveRequest);
            }
            else
            {
                Console.WriteLine("Approverd by ProjectManager");
            }

        }

    }
}
