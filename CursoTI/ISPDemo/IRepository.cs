using System.Collections.Generic;

namespace ISPDemo
{
    public interface IRepository<T>
    {
        void Create(T entity);
        T RetrieveById(int id);
        IEnumerable<T> RetrieveAll();
        void Update(T entity);
        void Delete(int id);
    }
}
