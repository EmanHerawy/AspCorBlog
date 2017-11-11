using System.Linq;

namespace AspCoreBlog.core.repository
{
    public interface IEfCoreRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}