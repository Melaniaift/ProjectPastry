using PASTRY.DomainEntities;
using System.Linq;

namespace PASTRYInfrastructure.DataAccess
{
    public interface IDataRepository
    {
        IQueryable<TEntity> Query<TEntity>() where TEntity : class, IEntityBase;

        void Delete<TEntity>(TEntity entity) where TEntity : class, IEntityBase;

        void Update<TEntity>(TEntity entity) where TEntity : class, IEntityBase;

        void Insert<TEntity>(TEntity entity) where TEntity : class, IEntityBase;
    }
}