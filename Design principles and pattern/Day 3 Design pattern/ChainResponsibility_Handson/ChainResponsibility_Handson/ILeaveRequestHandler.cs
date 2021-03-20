using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility_Handson
{
    interface ILeaveRequestHandler
    {
        void HandleRequest(LeaveRequest leaveRequest);
    }
}
