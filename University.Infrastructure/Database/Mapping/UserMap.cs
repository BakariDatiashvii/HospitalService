using HospitalService.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Infrastructure.Database.Mapping
{
    public static class UserMap
    {
        public static void ConfigureUser(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<User>();

            entity.ToTable(nameof(User), "core");

            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedNever();

            entity.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            entity.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            entity.Property(x => x.Email).HasMaxLength(50).IsRequired();
            entity.Property(x => x.PrivateNumber).HasMaxLength(50).IsRequired();

            entity.HasOne(x => x.Person).WithOne(x => x.User).HasForeignKey<User>(x => x.PersonId);

            entity.HasOne(x => x.Doctor).WithOne(x => x.user).HasForeignKey<User>(x => x.DoctorId);

        }
    }
}
