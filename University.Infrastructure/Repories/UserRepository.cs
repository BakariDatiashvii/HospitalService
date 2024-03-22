using HospitalService.Domain.Contracts.Repositories;
using HospitalService.Domain.Entities.Users;
using HospitalService.Infrastructure.Database;
using HospitalService.Infrastructure.Repories.Base;


namespace HospitalService.Infrastructure.Repories
{
    public class UserRepository : GenerycRepository<User>, IUserRepository
    {
        public UserRepository(HospitalDbContext context) : base (context)
        {
            
        }
    }
}
