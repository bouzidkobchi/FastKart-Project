using FastKart.Data;
using FastKart.Data.Entities;
using FastKart.Data.Interfaces;

namespace FastKart.Data___second_approach
{
    public class GenericRepository<T, TKeyType> // where TKeyType : int , string and where T : class
    {
        /*
         * public class User : GenericRepository<User , int> because id is integer , but verify that user have id attribute
         * public class manufactor : GenericRepository<Manufactor , string> and the class have Id { get => Name } for ensure of containg Id field
         * each class inherit from this class can use its own interface to add more methods !
         */
        private static AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public TKeyType Add(T item)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<User> items)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(User item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Filter(Predicate<User> Condition)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> FilterPage(Predicate<User> Condition, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetPage(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> Select<TResult>(Func<User, TResult> func)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<User, TResult> func, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
