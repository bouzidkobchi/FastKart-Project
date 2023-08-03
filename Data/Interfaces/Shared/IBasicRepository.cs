using System.Linq.Expressions;

namespace FastKart.Data.Interfaces.Shared
{
    public interface IBasicRepository<T>
    {
        // Read :
        int Count();
        IEnumerable<T> GetAll();
        IEnumerable<T> GetPage(int page, int pageSize);
        IEnumerable<T> Filter(Predicate<T> Condition);
        IEnumerable<T> FilterPage(Predicate<T> Condition , int page , int pageSize);
        IEnumerable<TResult> Select<TResult>(Func<T , TResult> func); 
        IEnumerable<TResult> SelectPage<TResult>(Func<T , TResult> func , int page , int pageSize); 

        // Create :
        int Add(T item);
        void AddRange(IEnumerable<T> items);

        // Update :
        void Update(T item , Action<T> action);

        // Delete :
        void Delete(T item);
    }
}
