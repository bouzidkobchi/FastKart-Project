using FastKart.Data.Entities;
using FastKart.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastKart.Data.Repositories
{
    [NotMapped]
    public class UserRepository : IUserRepository
    {
        private AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User? GetById(int UserId)
        {
            return _context.Users.FirstOrDefault(U => U.Id == UserId);
        }

        public int Add(User item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public void AddRange(IEnumerable<User> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Users.Count();
        }

        public void Delete(User item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int UserId)
        {
            var deletedUser = _context.Users.First(U => U.Id == UserId);
            _context.Users.Remove(deletedUser);
            _context.SaveChanges();
        }

        public IEnumerable<User> Filter(Predicate<User> Condition)
        {
            return _context.Users.Where(U => Condition(U));
        }

        public IEnumerable<User> FilterPage(Predicate<User> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public IEnumerable<User> GetPage(int page, int pageSize)
        {
            return _context.Users.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<TResult> Select<TResult>(Func<User, TResult> func)
        {
            return _context.Users.Select(U => func(U));
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<User, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(User item)
        {
            _context.Users.Update(item);
            _context.SaveChanges();
        }
    }
}
