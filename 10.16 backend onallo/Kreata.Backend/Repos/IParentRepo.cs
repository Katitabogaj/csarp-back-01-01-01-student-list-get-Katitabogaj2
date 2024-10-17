using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface IParentRepo
    {
        Task<List<Parent>> GetAll();
        Task<Parent?> GetBy(Guid id);
    }
}
