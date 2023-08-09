using FastKart.Data.Entities;
using FastKart.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastKart.Data.Repositories
{
    [NotMapped]
    public class PaymentRepository : IPaymentRepository
    {
        private readonly AppDbContext _context;
        public PaymentRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(paymentMethod item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return 1;
        }

        public void AddRange(IEnumerable<paymentMethod> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.paymentMethods.Count();
        }

        public void Delete(paymentMethod item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<paymentMethod> Filter(Predicate<paymentMethod> Condition)
        {
            return _context.paymentMethods.Where(P => Condition(P));
        }

        public IEnumerable<paymentMethod> FilterPage(Predicate<paymentMethod> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<paymentMethod> GetAll()
        {
            return _context.paymentMethods;
        }

        public IEnumerable<paymentMethod> GetPage(int page, int pageSize)
        {
            return _context.paymentMethods.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<string> GetPaymentNames()
        {
            var Names = from pay in _context.paymentMethods
                        select pay.Name;

            return Names;
        }

        public IEnumerable<TResult> Select<TResult>(Func<paymentMethod, TResult> func)
        {
            return _context.paymentMethods.Select(P => func(P));
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<paymentMethod, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(paymentMethod item, Action<paymentMethod> action)
        {
            action(item);
            _context.SaveChanges();
        }
    }
}
