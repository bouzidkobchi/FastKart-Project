using FastKart.Data.Entities;
using FastKart.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastKart.Data.Repositories
{
    [NotMapped]
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Product item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public void AddRange(IEnumerable<Product> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Products.Count();
        }

        public void Delete(Product item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<Product> Filter(Predicate<Product> Condition)
        {
            return _context.Products.Where(P =>  Condition(P));
        }

        public IEnumerable<Product> FilterPage(Predicate<Product> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public IEnumerable<Product> GetPage(int page, int pageSize)
        {
            return _context.Products.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<TResult> Select<TResult>(Func<Product, TResult> func)
        {
            return _context.Products.Select(P => func(P));
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Product, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(Product item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
