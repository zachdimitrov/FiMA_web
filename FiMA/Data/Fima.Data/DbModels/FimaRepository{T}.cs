namespace Fima.Data.DbModels
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using DbModels;

    public class FimaRepository<T> : IFimaRepository<T>
        where T : class
    {
        public FimaRepository(KpEntitiesContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of FimaContext is required to use this repository.", nameof(context));
            }

            this.Context = context;
            this.DbSet = this.Context.Set<T>();
        }

        private IDbSet<T> DbSet { get; }

        private DbContext Context { get; }

        public IQueryable<T> All()
        {
            return this.DbSet;
        }

        public T GetById(object id)
        {
            var item = this.DbSet.Find(id);
            return item;
        }

        public void Add(T entity)
        {
            this.DbSet.Add(entity);
        }

        public void HardDelete(T entity)
        {
            this.DbSet.Remove(entity);
        }

        public void Save()
        {
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }
    }
}
