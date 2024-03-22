using HospitalService.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Contracts.Repositories
{
    public interface IAuthorizedUserService 
    {
        ClaimsPrincipal GetAuthorizedUser();

        bool IsAuthorized();

        Guid GetCurrentPersonId();

        Guid GetCurrentDoctorId();

        string GenerateToken(User user);
    }
}
