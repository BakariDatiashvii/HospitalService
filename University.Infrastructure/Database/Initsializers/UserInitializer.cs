using HospitalService.Domain.Entities.Users;
using HospitalService.Domain.Service;
using HospitalService.Shared.Enumes;
using Microsoft.EntityFrameworkCore;

namespace HospitalService.Infrastructure.Database.Initsializers
{
    public static class UserInitializer
    {
        public static void InitializeUser(this ModelBuilder modelBuilder)
        {
            IEnumerable<User> userSeed = new List<User>()
            {
                new User()
                {
                    FirstName = "admin",
                    LastName = "admin",
                    Email = "1",
                    Role = Role.Admin,
                    PrivateNumber = "admin",
                 
                }
            };

            AuthService authService = new AuthService();

            byte[] pasHesh;
            byte[] pasSalt;

            foreach (var user in userSeed)
            {
                authService.CreatePasswordHash("1", out pasHesh, out pasSalt);
                user.PasswordHash = pasHesh;
                user.PasswordSalt = pasSalt;
            }

            modelBuilder.Entity<User>()
                .HasData(userSeed);
        }
    }
}
