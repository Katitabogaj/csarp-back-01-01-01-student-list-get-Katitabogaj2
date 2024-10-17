using Kreata.Backend.Context;
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
            public async Task<List<Pizzeriak>> GetAll()
            {
                return await _dbContext.Pizzeriaks.ToListAsync();
            }

            public async Task<Pizzeriak?> GetBy(Guid id)
            {
                return await _dbContext.Pizzeriaks.FirstOrDefaultAsync(t => t.Id == id);
            }
    }
}
