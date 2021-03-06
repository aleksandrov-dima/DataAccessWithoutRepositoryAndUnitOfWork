﻿using Infrastructure.Interfaces.QueryableHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    public class InMemoryQueryableExecutor : IQueryableExecutor
    {
        public async Task<List<TEntity>> ToListAsync<TEntity>(IQueryable<TEntity> query)
        {
            return query.ToList();
        }
    }
}
