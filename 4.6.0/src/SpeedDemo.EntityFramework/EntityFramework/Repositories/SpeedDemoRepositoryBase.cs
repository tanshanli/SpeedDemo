using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SpeedDemo.EntityFramework.Repositories
{
    public abstract class SpeedDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SpeedDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SpeedDemoRepositoryBase(IDbContextProvider<SpeedDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SpeedDemoRepositoryBase<TEntity> : SpeedDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SpeedDemoRepositoryBase(IDbContextProvider<SpeedDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
