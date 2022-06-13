using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.DTOs.LeaveRequest
{
    public class UpdateLeaveRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int LeaveTypeId { get; set; }

        public string RequestComments { get; set; }

        public bool Cancel { get; set; }
    }
}
