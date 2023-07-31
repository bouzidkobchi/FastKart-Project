using FastKart.Data.Entities;

namespace FastKart.Data.Interfaces
{
    public interface ICategoryRepository
    {
        // Read :
        int Count();
        Dictionary<Category, int> ProductPerCategory();
        IEnumerable<Category> GetAllCategories();
        IEnumerable<string> GetAllCategoryNames();

        // Create :
        int AddCategory(string CategoryName);

        // Update :
        void UpdateCategory(Category Category , string Name);
        void UpdateCategory(string CategoryName , string Name);

        // Delete :
        void DeleteCategory(string CategoryName);
        void DeleteCategory(Category Category);
    }
}
