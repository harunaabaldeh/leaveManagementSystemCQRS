using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.DTOs
{
    public class LeaveRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public LeaveTypeDto LeaveType { get; set; }

        public int LeaveTypeID { get; set; }

        public DateTime DateRequested { get; set; }

        public string RequestComments { get; set; }

        public DateTime? DateActioned { get; set; }

        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }
    }
}
