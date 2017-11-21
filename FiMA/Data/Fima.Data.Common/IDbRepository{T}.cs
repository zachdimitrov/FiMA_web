namespace Fima.Data.Common
{
    using System.Linq;

    public interface IDbRepository<T>
        where T : class
    {
        void Add(T entity);

        IQueryable<T> All();

        void Dispose();

        T GetById(object id);

        void HardDelete(T entity);

        void Save();
    }
}
