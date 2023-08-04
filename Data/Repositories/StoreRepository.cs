using FastKart.Data.Entities;
using FastKart.Data.Interfaces;

namespace FastKart.Data.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private AppDbContext _context;
        public StoreRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Store item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return 1;
        }

        public void AddRange(IEnumerable<Store> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Stores.Count();
        }

        public void Delete(Store item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<Store> Filter(Predicate<Store> Condition)
        {
            return _context.Stores.Where(S => Condition(S));
        }

        public IEnumerable<Store> FilterPage(Predicate<Store> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<Store> GetAll()
        {
            return _context.Stores;
        }

        public IEnumerable<Store> GetPage(int page, int pageSize)
        {
            return _context.Stores.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<string> GetStoreNames()
        {
            var Names = from store in _context.Stores
                        select store.Name;

            return Names;
        }

        public IEnumerable<TResult> Select<TResult>(Func<Store, TResult> func)
        {
            return _context.Stores.Select(S => func(S));
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Store, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(Store item, Action<Store> action)
        {
            action(item);
            _context.SaveChanges();
        }
    }
}
