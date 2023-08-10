using FastKart.Data.Entities;
using FastKart.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastKart.Data.Repositories
{
    [NotMapped]
    public class ManufactorRepository : IManufactorRepository
    {
        private readonly AppDbContext _context;
        public ManufactorRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Manufactor item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return 1;
        }

        public int AddForm(string ManufactorName)
        {
            //verify existance before !
            _context.Manufactors.Add(new Manufactor { Name = ManufactorName });
            _context.SaveChanges();
            return 1;
        }

        public void AddRange(IEnumerable<Manufactor> items)
        {
            _context.AddRange(items);
            _context.SaveChanges ();
        }

        public int Count()
        {
            return _context.Manufactors.Count();
        }

        public void Delete(Manufactor item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }
        
        public void Delete(string ManufactorName)
        {
            var Manufactor = _context.Manufactors.FirstOrDefault(M => M.Name == ManufactorName);
            if(Manufactor is not null)
            {
                _context.Remove(Manufactor);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Manufactor> Filter(Predicate<Manufactor> Condition)
        {
            return _context.Manufactors.Where(M => Condition(M));
        }

        public IEnumerable<Manufactor> FilterPage(Predicate<Manufactor> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<Manufactor> GetAll()
        {
            return _context.Manufactors;
        }

        public IEnumerable<string> GetAllManufactorNames()
        {
            var Names = from manufactor in _context.Manufactors
                        select manufactor.Name;

            return Names;
        }

        public IEnumerable<Manufactor> GetPage(int page, int pageSize)
        {
            return _context.Manufactors.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<TResult> Select<TResult>(Func<Manufactor, TResult> func)
        {
            return _context.Manufactors.Select(M => func(M));
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Manufactor, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(Manufactor item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
