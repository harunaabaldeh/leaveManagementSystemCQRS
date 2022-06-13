﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        
        public LeaveTypeDto LeaveType { get; set; }

        public DateTime DateRequested { get; set; }

        public bool? Approved { get; set; }
    }
}
