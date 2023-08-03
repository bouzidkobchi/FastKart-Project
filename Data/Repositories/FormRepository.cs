using FastKart.Data.Entities;
using FastKart.Data.Interfaces;

namespace FastKart.Data.Repositories
{
    public class FormRepository : IFormRepository
    {
        private readonly AppDbContext _context;
        public FormRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Form item)
        {
            _context.Forms.Add(item);
            _context.SaveChanges();
            return 1;
        }

        public void AddRange(IEnumerable<Form> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Forms.Count();
        }

        public void Delete(Form item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<Form> Filter(Predicate<Form> Condition)
        {
            return _context.Forms.Where(F => Condition(F));
        }

        public IEnumerable<Form> FilterPage(Predicate<Form> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(page);
        }

        public IEnumerable<Form> GetAll()
        {
            return _context.Forms;
        }

        public IEnumerable<Form> GetPage(int page, int pageSize)
        {
            return _context.Forms.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<TResult> Select<TResult>(Func<Form, TResult> func)
        {
            return _context.Forms.Select(func);
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Form, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(Form item, Action<Form> action)
        {
            action(item);
            _context.SaveChanges();
        }
    }
}
