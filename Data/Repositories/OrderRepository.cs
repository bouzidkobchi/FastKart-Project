using FastKart.Data.Entities;
using FastKart.Data.Interfaces;

namespace FastKart.Data.Repositories
{
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
            throw new NotImplementedException();
        }

        public IEnumerable<Order> FilterPage(Predicate<Order> Condition, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetPage(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> Select<TResult>(Func<Order, TResult> func)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Order, TResult> func, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void Update(Order item, Action<Order> action)
        {
            throw new NotImplementedException();
        }
    }
}
