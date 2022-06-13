using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leaveManagementDomain.Common;

namespace leaveManagementDomain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        //public int Id { get; set; }
        public int NumberOfDays { get; set; }
        //public DateTime DateCreated { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
