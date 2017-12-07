namespace Fima.Data.DbModels
{
    using System.Linq;

    public interface IFimaRepository<T>
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
