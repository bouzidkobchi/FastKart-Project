using FastKart.Data.Entities;
using FastKart.Data.Interfaces.Shared;

namespace FastKart.Data.Interfaces
{
    public interface IRoleRepository : IBasicRepository<Role>
    {
        IEnumerable<string> GetRoleNames();
    }
}
