using FastKart.Data.Entities;
using FastKart.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastKart.Data.Repositories
{
    [NotMapped]
    public class MediaRepository : IMediaRepository
    {
        private readonly AppDbContext _context;
        public MediaRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Media item)
        {
            _context.Media.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public void AddRange(IEnumerable<Media> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Media.Count();
        }

        public void Delete(Media item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public void delete(int mediaId)
        {
            var deleted = _context.Media.Find(mediaId);
            if (deleted is not null)
            {
                _context.Remove(deleted);
                _context.SaveChanges();
            }

        }

        public IEnumerable<Media> Filter(Predicate<Media> Condition)
        {
            return _context.Media.Where(M => Condition(M));
        }

        public IEnumerable<Media> FilterPage(Predicate<Media> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<Media> GetAll()
        {
            return _context.Media;
        }

        public IEnumerable<Media> GetPage(int page, int pageSize)
        {
            return _context.Media.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<TResult> Select<TResult>(Func<Media, TResult> func)
        {
            return _context.Media.Select(M => func(M));
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Media, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(Media item, Action<Media> action)
        {
            action(item);
            _context.SaveChanges();
        }
    }
}
