using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.DTOs
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }

        public int DefaultDays { get; set; }
    }
}
