using FastKart.Data.Entities;
using FastKart.Data.Interfaces.Shared;

namespace FastKart.Data.Interfaces
{
    public interface ICategoryRepository : IBasicRepository<Category>
    {
        IEnumerable<string> GetAllCategoryNames();
    }
}
