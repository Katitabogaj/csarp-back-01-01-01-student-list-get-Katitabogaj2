using Kreata.Backend.Context;
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
        public async Task<Pasta?>
    }
}
