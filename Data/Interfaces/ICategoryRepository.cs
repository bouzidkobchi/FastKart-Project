using FastKart.Data.Entities;
using FastKart.Data.Interfaces.Shared;

namespace FastKart.Data.Interfaces
{
    public interface ICategoryRepository : IBasicRepository<Category>
    {
        // Read :
        Dictionary<Category, int> ProductPerCategory();
        IEnumerable<string> GetAllCategoryNames();
    }
}
