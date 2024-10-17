﻿using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class PizzeriakRepo : IPizzeriakRepo
    {
        
            private readonly KretaInMemoryContext _dbContext;

            public PizzeriakRepo(KretaInMemoryContext dbContext)
            {
                _dbContext = dbContext;
            }
            public async Task<List<Parent>> GetAll()
            {
                return await _dbContext.Parents.ToListAsync();
            }

            public async Task<Parent?> GetBy(Guid id)
            {
                return await _dbContext.Parents.FirstOrDefaultAsync(t => t.Id == id);
            }
    }
}
