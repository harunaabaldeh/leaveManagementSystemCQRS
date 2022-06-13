using leaveManagementApplication.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.Features.LeaveAllocations.Request.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationListDto>>
    {

    }
}
