using leaveManagementApplication.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.Features.LeaveAllocations.Request.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationListDto>
    {
        public int Id { get; set; }
    }
}
