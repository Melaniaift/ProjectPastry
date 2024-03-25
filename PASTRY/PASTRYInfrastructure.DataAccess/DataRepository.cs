using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PASTRYInfrastructure.DataAccess;

namespace PASTRYInfrastructure.DataAccess
{
    public class DataRepository : IDataRepository
    {
        private readonly MvcCakeContext dataContext;
        public DataRepository(MvcCakeContext dataContext)
        {
            this.dataContext = dataContext;
        }
        IQueryable<TEntity> IDataRepository.Query<TEntity>()
        {
            return dataContext.Set<TEntity>();
        }
        void IDataRepository.Delete<TEntity>(TEntity entity)
        {
            var dbEntity = dataContext.Set<TEntity>()
                .SingleOrDefault(e => e.Id == entity.Id);
            if (dbEntity != null)
            {
                dataContext.Remove(dbEntity);
            }
        }

        void IDataRepository.Insert<TEntity>(TEntity entity)
        {
            dataContext.Add(entity);
        }


        void IDataRepository.Update<TEntity>(TEntity entity)
        {
            dataContext.Update(entity);
        }
    }
}
