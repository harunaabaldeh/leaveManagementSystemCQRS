using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leaveManagementDomain;

namespace leaveManagementApplication.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int Id);
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
    }
}
