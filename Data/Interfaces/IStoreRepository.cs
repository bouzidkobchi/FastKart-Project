using FastKart.Data.Entities;
using FastKart.Data.Interfaces.Shared;

namespace FastKart.Data.Interfaces
{
    public interface IStoreRepository : IBasicRepository<Store>
    {
        IEnumerable<string> GetStoreNames();
    }
}
