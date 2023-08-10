using FastKart.Data.Entities;
using FastKart.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastKart.Data.Repositories
{
    [NotMapped]
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDbContext _context;
        public RoleRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Role item)
        {
            _context.Roles.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public void AddRange(IEnumerable<Role> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Roles.Count();
        }

        public void Delete(Role item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<Role> Filter(Predicate<Role> Condition)
        {
            return _context.Roles.Where(R => Condition(R));
        }

        public IEnumerable<Role> FilterPage(Predicate<Role> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<Role> GetAll()
        {
            return _context.Roles;
        }

        public IEnumerable<Role> GetPage(int page, int pageSize)
        {
            return _context.Roles.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<string> GetRoleNames()
        {
            var Names = from role in _context.Roles
                        select role.Name;

            return Names;
        }

        public IEnumerable<TResult> Select<TResult>(Func<Role, TResult> func)
        {
            return _context.Roles.Select(R => func(R));
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Role, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(Role item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
