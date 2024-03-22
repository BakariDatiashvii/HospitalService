using HospitalService.Domain.Contracts.Repositories.Base;
using HospitalService.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace HospitalService.Infrastructure.Repories.Base
{
    public class GenerycRepository<TEntity> : IGenerycRepository<TEntity> where TEntity : class
    {
        public HospitalDbContext Context { get; set; }
        public GenerycRepository(HospitalDbContext context)
        {
            Context = context;
        }

        public void Create(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return Context.Set<TEntity>().AsQueryable().AsNoTracking();
        }

        public void CreateMany(List<TEntity> entities)
        {

            Context.Set<TEntity>().AddRange(entities);
        }

        public void UpdateMany(List<TEntity> entities)
        {
            Context.Set<TEntity>().UpdateRange(entities);
        }

        public void DeleteMany(List<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
