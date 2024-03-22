using HospitalService.Domain.Entities.Users;
using System.Security.Claims;

namespace HospitalService.Domain.Contracts
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
