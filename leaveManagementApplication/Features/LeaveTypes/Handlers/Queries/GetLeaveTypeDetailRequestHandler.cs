﻿using AutoMapper;
using leaveManagementApplication.DTOs;
using leaveManagementApplication.Features.LeaveTypes.Request;
using leaveManagementApplication.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetLeaveRequestsWithDetails(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
            //throw new NotImplementedException();
        }
    }
}
