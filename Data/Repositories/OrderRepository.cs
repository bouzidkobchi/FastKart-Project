using FastKart.Data.Entities;
using FastKart.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastKart.Data.Repositories
{
    [NotMapped]
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Order item)
        {
            _context.Orders.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public void AddRange(IEnumerable<Order> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Orders.Count();
        }

        public void Delete(Order item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<Order> Filter(Predicate<Order> Condition)
        {
            return _context.Orders.Where(O => Condition(O));
        }

        public IEnumerable<Order> FilterPage(Predicate<Order> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders;
        }

        public IEnumerable<Order> GetPage(int page, int pageSize)
        {
            return _context.Orders.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<TResult> Select<TResult>(Func<Order, TResult> func)
        {
            return _context.Orders.Select(O => func(O));
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Order, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(Order item, Action<Order> action)
        {
            action(item);
            _context.SaveChanges();
        }
    }
}
