namespace Fima.Data.DbModels
{
    using System.Data.Entity;
    using System.Data.Entity.Validation;
    using Common;

    public partial class KpEntitiesContext : DbContext
    {
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                var newException = new FormattedDbEntityValidationException(e);
                throw newException;
            }
        }
    }
}
