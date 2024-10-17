using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface IPizzeriakRepo
    {
        Task<List<Pizzeriak>> GetAll();
        Task<Pizzeriak?> GetBy(Guid id);
    }
}
