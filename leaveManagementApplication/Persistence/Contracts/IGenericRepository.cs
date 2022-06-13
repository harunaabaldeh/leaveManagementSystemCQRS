﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaveManagementApplication.Persistence.Contracts
{
    public interface IGenericRepository <T> where T : class

    {
        Task<T> Get(int id);

        Task<T> GetLeaveRequestsWithDetails(int id);

        Task<IReadOnlyList<T>> GetAll();

        Task<T> Add (T entity);

        Task<T> Update (T entity);

        Task Delete(T entity);
    }
}
