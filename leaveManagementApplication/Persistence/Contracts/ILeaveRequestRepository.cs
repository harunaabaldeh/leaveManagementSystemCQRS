using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leaveManagementDomain;

namespace leaveManagementApplication.Persistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int Id);

        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();

        Task  ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus);
    }
}
