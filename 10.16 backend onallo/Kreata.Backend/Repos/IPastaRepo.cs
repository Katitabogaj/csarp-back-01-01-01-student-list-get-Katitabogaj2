using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface IPastaRepo
    {
        Task<List<Pasta>> GetAll();
        Task<Pasta?> GetBy(Guid id);
    }
}
