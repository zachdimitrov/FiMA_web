namespace Fima.Services.Data.Common.Contracts
{
    using System.Linq;

    public interface IBaseDataService<T>
        where T : class
    {
        void Add(T item);

        void Delete(object id);

        IQueryable<T> GetAll();

        T GetById(object id);

        void Save();

        void Dispose();
    }
}
