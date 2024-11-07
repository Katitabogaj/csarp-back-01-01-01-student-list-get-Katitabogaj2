using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class PastaRepo : IPastaRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public PastaRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Pasta>> GetAll()
        {
            return await _dbContext.Pastas.ToListAsync();
        }

        public async Task<Pasta?> GetBy(Guid id)
        {
            return await _dbContext.Pastas.FirstOrDefaultAsync(t => t.Id == id);
        }

    }
}
