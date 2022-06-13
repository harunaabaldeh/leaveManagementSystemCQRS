using leaveManagementApplication.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.Features.LeaveTypes.Request.Commands
{
    public class CreateLeaveTypeCommad : IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
