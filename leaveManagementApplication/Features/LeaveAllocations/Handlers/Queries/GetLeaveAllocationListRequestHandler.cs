using AutoMapper;
using leaveManagementApplication.DTOs;
using leaveManagementApplication.DTOs.LeaveRequest;
using leaveManagementApplication.Features.LeaveAllocations.Request.Queries;
using leaveManagementApplication.Features.LeaveRequests.Requests.Queries;
using leaveManagementApplication.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationListDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationListRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
           _mapper = mapper;
        }

   

        public async Task<List<LeaveAllocationListDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = await _leaveRequestRepository.GetLeaveRequestsWithDetails();
            return _mapper.Map<List<LeaveAllocationListDto>>(leaveRequests);
            //throw new NotImplementedException();
        }

     
    }
}
