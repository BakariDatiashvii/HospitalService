using HospitalService.Domain.Contracts;
using HospitalService.Infrastructure.Database;

namespace HospitalService.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public HospitalDbContext Context { get; set; }

        public UnitOfWork(HospitalDbContext context)
        {
            Context = context;
        }
        public int SaveChange()
        {
            return Context.SaveChanges();
        }
    }
}
