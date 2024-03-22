using HospitalService.Domain.Contracts.Repositories.Base;
using HospitalService.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Contracts.Repositories
{
    public interface IUserRepository : IGenerycRepository<User>
    {
    }
}
