using FastKart.Data.Entities;
using FastKart.Data.Interfaces;

namespace FastKart.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Category item)
        {
            _context.Categories.Add(item);
            _context.SaveChanges();
            return 1;
        }

        public void AddRange(IEnumerable<Category> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Categories.Count();
        }

        public void Delete(Predicate<Category>? Condition, int Count = 1)
        {
            var DeletedCards = _context.Categories.Where(C => Condition(C));
            _context.RemoveRange(DeletedCards);
            _context.SaveChanges() ;
        }

        public void Delete(Category item)
        {
            _context.Remove(item);
        }

        public IEnumerable<Category> Filter(Predicate<Category> Condition)
        {
            return _context.Categories.Where(C => Condition(C));
        }

        public IEnumerable<Category> FilterPage(Predicate<Category> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }

        public IEnumerable<string> GetAllCategoryNames()
        {
             var Names = from category in _context.Categories
                         select category.Name;

            return Names;
        }

        public IEnumerable<Category> GetPage(int page, int pageSize)
        {
            return _context.Categories.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<TResult> Select<TResult>(Func<Category, TResult> func)
        {
            return _context.Categories.Select(func);
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Category, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(Category item, Action<Category> action)
        {
            action(item);
            _context.SaveChanges();
        }
    }
}
