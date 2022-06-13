using AutoMapper;
using leaveManagementApplication.Features.LeaveAllocations.Request.Commands;
using leaveManagementApplication.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.Features.LeaveAllocations.Handlers.Commands
{
    public class DeleteLeaveAllocationCommadHandler : IRequestHandler<DeleteLeaveAllocationCommad>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveAllocationCommadHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveAllocationCommad request, CancellationToken cancellationToken)
        {
            var leaveAllocation  = await _leaveAllocationRepository.Get(request.Id);

            await _leaveAllocationRepository.Delete(leaveAllocation);

            return Unit.Value; 
        }
    }
}
